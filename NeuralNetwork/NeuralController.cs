using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class NeuralController
    {
        private Random rand = new Random();
        private InputNeuron[] InputNeurons;
        private HiddenNeuron[][] HiddenNeurons;
        private OutputNeuron[] OutputNeurons;
        public NeuralController(int input, int hidden, int hiddenLayers, int output, string[] output_values)
        {
            // Inputs
            this.InputNeurons = new InputNeuron[input];
            CreateInputNeurons(input);

            // Hiddens
            this.HiddenNeurons = new HiddenNeuron[hiddenLayers][];
            for (int layer = 0; layer < hiddenLayers; layer++)
            {
                this.HiddenNeurons[layer] = new HiddenNeuron[hidden];
            }
            CreateHiddenNeurons(hidden, hiddenLayers, input);

            // Outputs
            this.OutputNeurons = new OutputNeuron[output];
            CreateOutputNeurons(output, hidden, output_values);
        }

        // NeuralNetwork Control
        public string TestNeuralNetwork(double[] InputData)
        {
            if (InputData.Length < InputNeurons.Length)
            {
                return "ERROR: TestNeuralNetwork, InputData";
            }

            ChangeValueInputNeurons(InputData);
            RecalculateResult();
            return OutputResult();
        }
        // Hidden funcrions to NeuralNetwork Control
        private string OutputResult()
        {
            string Result = "ERROR: OutputResult";
            double Max = 0;

            for (int output = 0; output < OutputNeurons.Length; output++)
            {
                if (OutputNeurons[output].value > Max)
                {
                    Max = OutputNeurons[output].value;
                    Result = OutputNeurons[output].association;
                }
            }

            return Result;
        }
        private double SigmoidNormalize(double In)
        {
            //return Math.Tanh(In);
            return 1d / (1d + Math.Exp(-In));
        }
        private void RecalculateResult()
        {
            // zero layer with first input neurons
            for (int hidden = 0; hidden < HiddenNeurons[0].Length; hidden++)
            {
                HiddenNeurons[0][hidden].value = 0;
                for (int input = 0; input < InputNeurons.Length; input++)
                {
                    HiddenNeurons[0][hidden].value += HiddenNeurons[0][hidden].weights[input] * InputNeurons[input].value;
                }
                HiddenNeurons[0][hidden].value -= HiddenNeurons[0][hidden].bias;
                HiddenNeurons[0][hidden].value = SigmoidNormalize(HiddenNeurons[0][hidden].value);
            }
            // remaining layers of hidden neurons
            for (int layer = 1; layer < HiddenNeurons.Length; layer++)
            {
                for (int hidden = 0; hidden < HiddenNeurons[layer].Length; hidden++)
                {
                    HiddenNeurons[layer][hidden].value = 0d;
                    for (int prevHidden = 0; prevHidden < HiddenNeurons[layer-1].Length; prevHidden++)
                    {
                        HiddenNeurons[layer][hidden].value += HiddenNeurons[layer][hidden].weights[prevHidden] * HiddenNeurons[layer-1][prevHidden].value;
                    }
                    HiddenNeurons[layer][hidden].value -= HiddenNeurons[layer][hidden].bias;
                    HiddenNeurons[layer][hidden].value = SigmoidNormalize(HiddenNeurons[layer][hidden].value);
                }
            }
            // output neurons calculate
            for (int output = 0; output < OutputNeurons.Length; output++)
            {
                OutputNeurons[output].value = 0;
                for (int lastHidden = 0; lastHidden < HiddenNeurons[HiddenNeurons.Length-1].Length; lastHidden++)
                {
                    OutputNeurons[output].value += OutputNeurons[output].weights[lastHidden] * HiddenNeurons[HiddenNeurons.Length-1][lastHidden].value;
                }
                OutputNeurons[output].value -= OutputNeurons[output].bias;
                OutputNeurons[output].value = SigmoidNormalize(OutputNeurons[output].value);
            }
        }
        private void ChangeValueInputNeurons(double[] Data)
        {
            for (int place = 0; place < InputNeurons.Length; place++)
            {
                InputNeurons[place].value = Data[place];
            }
        }

        // Create much neurons
        private void CreateInputNeurons(int count)
        {
            for (int place = 0; place < InputNeurons.Length; place++)
            {
                InputNeurons[place] = CreateInputNeuron();
            }
        }
        private void CreateHiddenNeurons(int hidden, int hiddenLayers, int CountInputNeurons)
        {
            int weightsCount = CountInputNeurons;
            for (int layer = 0; layer < hiddenLayers; layer++)
            {
                for (int place = 0; place < hidden; place++)
                {
                    HiddenNeurons[layer][place] = CreateHiddenNeuron(weightsCount);
                }
                weightsCount = hidden;
            }
        }
        private void CreateOutputNeurons(int count, int CountHiddenNeurons, string[] output_assocs)
        {
            for (int place = 0; place < count; place++)
            {
                OutputNeurons[place] = CreateOutputNeuron(CountHiddenNeurons, output_assocs[place]);
            }
        }

        // Create one type neuron
        private InputNeuron CreateInputNeuron()
        {
            return new InputNeuron(rand.Next(-100, 100) / 100);
        }
        private HiddenNeuron CreateHiddenNeuron(int weightsCount)
        {
            double[] weights = new double[weightsCount];

            for (int w = 0; w < weightsCount; w++)
            {
                weights[w] = rand.Next(-1000, 1000) / 100d;
            }
            double bias = rand.Next(0, 100);
            return new HiddenNeuron(weights, bias);
        }
        private OutputNeuron CreateOutputNeuron(int weightsCount, string assoc)
        {
            double[] weights = new double[weightsCount];

            for (int w = 0; w < weights.Length; w++)
            {
                weights[w] = rand.Next(-1000, 1000) / 100d;
            }
            double bias = rand.Next(0, 100);
            return new OutputNeuron(weights, bias, assoc);
        }
    }
}
