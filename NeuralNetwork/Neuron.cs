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
        public HiddenNeuron(double[] weights)
        {
            this.weights = weights;
        }
    }
    public class OutputNeuron
    {
        public double value;
        public double[] weights;
        public string association;
        public OutputNeuron(double[] weights, string association)
        {
            this.weights = weights;
            this.association = association;
        }
    }
}
