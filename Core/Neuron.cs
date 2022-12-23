namespace NeuralNetwork.Core;
using Exceptions;
public class Neuron
{
    public Neuron(int weights, ActivationFunction function)
    {
        this.Weights = new float[weights];
        this.Function = function;
        this.Bias = gaussian();

        for (int i = 0; i < weights; i++)
            this.Weights[i] = gaussian();
    }
    public float[] Weights { get; private set; }
    public float Bias {get; private set; }
    public ActivationFunction Function { get; set; }
    public float Output(float[] input)
    {
        if (input.Length != Weights.Length)
            throw new InvalidParameterSizeExeception();

        float s = this.Bias;
        for (int i = 0; i < input.Length; i++)
            s += this.Weights[i] * input[i];

        float z = Function.Compute(s);
        return z;
    }

    private float gaussian(int n = 10)
    {
        var rand = Random.Shared;
        float sum = 0f;

        for (int i = 0; i < n; i++)
        {
            sum += 2 * rand.NextSingle() - 1;
        }
        return sum / n;
    }
}