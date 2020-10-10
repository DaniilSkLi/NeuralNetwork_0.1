using System;
using System.Collections.Generic;
using System.Linq;
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
        private void RecalculateResult()
        {
            // ziro layer with first input neurons
            for (int hidden = 0; hidden < HiddenNeurons[0].Length; hidden++)
            {
                HiddenNeurons[0][hidden].value = 0;
                for (int input = 0; input < InputNeurons.Length; input++)
                {
                    HiddenNeurons[0][hidden].value += HiddenNeurons[0][hidden].weights[input] * InputNeurons[input].value;
                }
            }
            // remaining layers of hidden neurons
            for (int layer = 1; layer < HiddenNeurons.Length; layer++)
            {
                for (int hidden = 0; hidden < HiddenNeurons[layer].Length; hidden++)
                {
                    HiddenNeurons[layer][hidden].value = 0;
                    for (int prevHidden = 0; prevHidden < HiddenNeurons[layer-1].Length; prevHidden++)
                    {
                        HiddenNeurons[layer][hidden].value += HiddenNeurons[layer][hidden].weights[prevHidden] * HiddenNeurons[layer-1][prevHidden].value;
                    }
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
                InputNeurons[place] = CreateInputNeuron(rand.NextDouble());
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
                    weightsCount = hidden;
                }
            }
        }
        private void CreateOutputNeurons(int count, int CountHiddenNeurons, string[] output_assocs)
        {
            for (int place = 0; place < OutputNeurons.Length; place++)
            {
                OutputNeurons[place] = CreateOutputNeuron(CountHiddenNeurons, output_assocs[place]);
            }
        }

        // Create one type neuron
        private InputNeuron CreateInputNeuron(double value)
        {
            return new InputNeuron(value);
        }
        private HiddenNeuron CreateHiddenNeuron(int weightsCount)
        {
            double[] weights = new double[weightsCount];

            for (int w = 0; w < weights.Length; w++)
            {
                weights[w] = rand.NextDouble();
            }
            return new HiddenNeuron(weights);
        }
        private OutputNeuron CreateOutputNeuron(int weightsCount, string assoc)
        {
            double[] weights = new double[weightsCount];

            for (int w = 0; w < weights.Length; w++)
            {
                weights[w] = rand.NextDouble();
            }
            return new OutputNeuron(weights, assoc);
        }
    }
}
