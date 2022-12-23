namespace NeuralNetwork.Core;
public class Relu : ActivationFunction
{
    public override float Compute(float input)
    {
        if (input < 0f)
            return 0f;
        return input;
    }
    public override float Derivate(float input)
    {
        if (input < 0f)
            return 0f;
        return input;
    }
}