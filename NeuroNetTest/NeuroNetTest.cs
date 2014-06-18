using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Belinskiy.NeuroNet;

namespace NeuroNetTest
{
    [TestClass]
    public class SynapseTest
    {
        [TestMethod]
        public void SetGetWeightTest()
        {
            double weight = 5;

            Synapse synapse = new Synapse();
            synapse.SetWeight(weight);

            Assert.AreEqual(synapse.GetWeight(), weight);
        }

        [TestMethod]
        public void SetGetSignalTest()
        {
            double signal = 9;

            Synapse synapse = new Synapse();
            synapse.SetSignal(signal);

            Assert.AreEqual(synapse.GetSignal(), signal);
        }
    }

    [TestClass]
    public class NeuronNetworkTest
    {
        [TestMethod]
        public void SetGetSignalInNetworkTest()
        {
            NeuronNetwork net = new NeuronNetwork();
            Assert.IsNotNull(net);

            List<double> signal = new List<double>();
            signal.AddRange(new double[] { 1, 5, 9 });

            net.SetSignal(signal);

            Assert.AreEqual(net.GetSignal(), signal);
        }

        [TestMethod]
        public void CreateInputLayerTest()
        {
            NeuronNetwork net = new NeuronNetwork();
            NeuronLayer layerTest = new NeuronLayer();
            List<double> signal = new List<double>();
            signal.AddRange(new double[] { 2, 5 });
            net.SetSignal(signal);
            net.CreateInputLayer();

        }
    }
}
