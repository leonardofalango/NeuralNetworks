namespace NeuralNetwork;
using System.Linq;
using Core;

public class NeuralNetwork
{
    public Layer[] Layers { get; private set; }
    public NeuralNetwork(ActivationFunction function, params int[] sizes)
    {
        for (int i = 0; i < sizes.Length; i++)
            Layers[i] = new Layer(
                sizes[i + 1],
                sizes[i],
                function
            );
        
    }
    public float[] Output(float[] input)
    {
        foreach (var layer in this.Layers)
            input = layer.Output(input);
        return input;
    }
    public (float, int) Choose(float[] input)
    {
        var output = this.Output(input);
        return output
            .Select((p, index) => (p, index))
            .MaxBy((t => t.p));
    }
    public void Fit(float[][] inputs)
    {
        /*TODO*/
    }
    public float Error(float[][] inputs, float[][] yReal)
    {
        float error = 0f;
        int i = 0;
        foreach (var input in inputs)
        {
            var output = this.Output(input);
            int j = 0;
            foreach (var yPredicted in input)
            {
                error += (yPredicted - yReal[i][j]) * (yPredicted - yReal[i][j]);
                j++;
            }
            i++;
        }
        return error;
    }
}