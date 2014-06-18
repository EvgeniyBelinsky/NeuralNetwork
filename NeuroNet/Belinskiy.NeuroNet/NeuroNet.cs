using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belinskiy.NeuroNet
{
    public class Synapse
    {
        private double signal;
        private double weight;

        public Neuron From;
        public Neuron To;        

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
        public double GetWeight()
        {
            return weight;
        }

        public  void SetSignal(double inputSignal)
        {
            signal = inputSignal;
        }

        public  double GetSignal()
        {
            return signal * weight;
        }

    }

    public class Neuron
    {
        public string name = ""; 
        public static int number = 0; 
        
        public List<Synapse> inputs;
        public List<Synapse> outputs;
        private double shift;
        private Function activationFunction;

        public Neuron()
        {
            inputs = new List<Synapse>();
            outputs = new List<Synapse>();
            number++;
            name = "n" + number.ToString();
        }

        public void AddInput(List<Synapse> inputs)
        {
            this.inputs = inputs;
        }

        public void AddInput(Synapse inputSynapse)
        {
            inputs.Add(inputSynapse);
        }

        public void AddOutput(Synapse outputSynapse)
        {
            outputs.Add(outputSynapse);
        }

        public void SetShift(double shift)
        {
            this.shift = shift;
        }

        public double GetActivationPotential()
        {
            double activationPotential = 0; 

            foreach(Synapse input in inputs)
            {
                activationPotential += input.GetSignal();
            }

            activationPotential += shift;

            return activationPotential; 
        }

        void SetActivationFunction(Function activFunc)
        {
            activationFunction = activFunc;
        }

        // методы для соединения нейронов
        public void ConnectNeuron(Neuron neuron, double signal, double weight)
        {
            Synapse newSynapse = new Synapse();
            newSynapse.From = this;
            newSynapse.To = neuron;
            
            outputs.Add(newSynapse);
            neuron.inputs.Add(newSynapse);
        }
    }

    public class NeuronLayer
    {
        public List<Neuron> neurons;

        public NeuronLayer()
        {
            neurons = new List<Neuron>();
        }

        public void AddNeurons(List<Neuron> neurons)
        {
            this.neurons = neurons;
        }
        public void AddNeuron(Neuron neuron)
        {
            neurons.Add(neuron);
        }

        // методы для соединения слоев
        public void ConnectLayer(NeuronLayer layer)
        {
            for (int i = 0; i < neurons.Count;i++ )
            {
                for (int j = 0; j < layer.neurons.Count; j++)
                {
                    neurons[i].ConnectNeuron(layer.neurons[j], 1, 5);
                }
            }
        }
    }

    public class NeuronNetwork
    {
        public NeuronLayer inputLayer = new NeuronLayer();
        public NeuronLayer outputLayer = new NeuronLayer();
        public List<NeuronLayer> hiddenLayers = new List<NeuronLayer>();

        private List<double> signal = new List<double>();
        
        public NeuronNetwork()
        {
        }
        public  void SetSignal(List<double> inputSignal)
        {
            signal = inputSignal;
        }

        public  List<double> GetSignal()
        {
            return signal;
        }
        
        public NeuronLayer CreateInputLayer(int countNeurons)
        {
            List<Neuron> inputNeurons = new List<Neuron>();
            List<Synapse> inputSynapse = new List<Synapse>();
            
            Random rand = new Random();

            for (int i = 0; i < countNeurons; i++ )
            {
                inputSynapse.Add(new Synapse());          
                inputNeurons.Add(new Neuron());

                inputSynapse[i].To = inputNeurons[i];
                inputNeurons[i].AddInput(inputSynapse[i]);
            }

            inputLayer.AddNeurons(inputNeurons);

            return inputLayer;
        }

        public NeuronLayer CreateOutputLayer(int countNeuron)
        {
            Neuron outputNeuron = null;
            Synapse outputSynapse = null;

            for (int i = 0; i < countNeuron; i++ )
            {
                outputNeuron = new Neuron();
                outputSynapse = new Synapse();

                outputSynapse.From = outputNeuron;
                outputNeuron.AddOutput(outputSynapse);

                outputLayer.AddNeuron(outputNeuron);
            }


            return outputLayer;
        }

        private NeuronLayer CreateHiddenLayer(int countNeurons)
        {
            NeuronLayer layer = new NeuronLayer();
            List<Neuron> hiddenNeurons = new List<Neuron>();

            for (int i = 0; i < countNeurons; i++ )
            {
                hiddenNeurons.Add(new Neuron());
            }

            layer.AddNeurons(hiddenNeurons);

            return layer;
        }

        public List<NeuronLayer> CreateHiddenLayers(int countNeuronInLayer, int countLayers)
        {
            for(int i=0; i<countLayers; i++)
            {
                hiddenLayers.Add(CreateHiddenLayer(countNeuronInLayer));
            }

            return hiddenLayers;
        }
    }

        public abstract class Function
        {
            public virtual double GetValue(double value)
            {
                return 0;
            }

            public virtual double GetFunctionDerivative(double value)
            {
                return 0;
            }
        }

        public class Sigmoid : Function
        {
            public override double GetValue(double value)
            {
                return 1.0 / (1.0 + Math.Exp(-value));
            }

            public override double GetFunctionDerivative(double value)
            {
                return value * (1.0 - value);
            }

        }

        public struct NeuronNetworkArchitecture
        {
            private int countInputNeurons;
            private int countOutputNeurons;
            private int countHiddenLayers;
            private int countNeuronsInLayer;

            public int CountInputNeurons
            {
                set
                {
                    countInputNeurons = value;
                }
                get
                {
                    return countInputNeurons;
                }
            }

            public int CountOutputNeurons
            {
                set
                {
                    countOutputNeurons = value;
                }
                get
                {
                    return countOutputNeurons;
                }
            }

            public int CountHiddenLayers
            {
                set
                {
                    countHiddenLayers = value;
                }
                get
                {
                    return countHiddenLayers;
                }
            }

            public int CountNeuronsInLayer
            {
                set
                {
                    countNeuronsInLayer = value;
                }
                get
                {
                    return countNeuronsInLayer;
                }
            }
        }

        public abstract class NeuroNetworkConstructor
        {
            public NeuroNetworkConstructor()
            {
            }

            protected NeuronNetwork network = new NeuronNetwork();

            protected NeuronLayer inputLayer = new NeuronLayer();
            protected NeuronLayer outputLayer = new NeuronLayer();

            protected List<double> inputSignal = new List<double>();

            protected Function activationFunction;

            

            public virtual void Create(List<double> signal, NeuronNetworkArchitecture architecture)
            {

            }
        }

        public class PerceptronConstructor : NeuroNetworkConstructor
        {           
            public PerceptronConstructor()
            {                
            }
            public override void Create(List<double> signal, NeuronNetworkArchitecture architecture)
            {              
                network.SetSignal(signal);

                if (architecture.CountInputNeurons > 0)
                {
                    inputLayer = network.CreateInputLayer(2);
                }
                else
                {
                    throw new Exception("Не задано количество входных нейронов");
                }
                if (architecture.CountOutputNeurons > 0)
                {
                    outputLayer = network.CreateOutputLayer(architecture.CountOutputNeurons);
                }
                else
                {
                    throw new Exception("Не задано количество выходных нейронов");
                }

                inputLayer.ConnectLayer(outputLayer);

                activationFunction = new Sigmoid();
            }

           
        }

        public abstract class StudyAlgorithm
        {
        }

        public abstract class StudyWithoutTeacher : StudyAlgorithm
        {
        }

        public abstract class StudyWithTeacher : StudyAlgorithm
        {
        }

        public class BackPropagation1 : StudyWithTeacher
        {
            public Synapse InitializeWeight(NeuronNetwork net)
            {
                Random rand = new Random();

                foreach (Neuron neuron in net.inputLayer.neurons)
                {
                    for(int j=0; j<net.inputLayer.neurons.Count; j++)
                    {
                        neuron.inputs[j].SetWeight(rand.NextDouble());
                    }
                 }
                return new Synapse();
            }


        }

        public class BackPropagation2 : StudyWithTeacher
        {
        }
        
}
