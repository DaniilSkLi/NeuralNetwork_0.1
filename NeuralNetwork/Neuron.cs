using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class InputNeuron
    {
        public double value;
        public InputNeuron(double value)
        {
            this.value = value;
        }
    }
    public class HiddenNeuron
    {
        public double value;
        public double[] weights;
        public double bias;
        public HiddenNeuron(double[] weights, double bias)
        {
            this.weights = weights;
            this.bias = bias;
        }
    }
    public class OutputNeuron
    {
        public double value;
        public double[] weights;
        public double bias;
        public string association;
        public OutputNeuron(double[] weights, double bias, string association)
        {
            this.weights = weights;
            this.bias = bias;
            this.association = association;
        }
    }
}
