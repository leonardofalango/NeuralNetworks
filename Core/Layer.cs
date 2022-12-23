namespace NeuralNetwork.Core;

public class Layer
{
    public Layer(int neurons, int inputSize, ActivationFunction function)
    {
        this.Neurons = new Neuron[neurons];
        for (int i = 0; i < neurons; i++)
            this.Neurons[i] = new Neuron(inputSize, function);
        
    }
    public Neuron[] Neurons { get; private set; }
    public float[] Output(float[] input)
    {
        float[] output = new float[this.Neurons.Length];
        for (int i = 0; i < output.Length; i++)
            output[i] = Neurons[i].Output(input);
        return output;
    }
}