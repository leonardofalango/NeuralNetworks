namespace NeuralNetwork;

using NeuralNetwork.Core;

public static class Functions
{
    private static ActivationFunction reLu = new Relu();
    public static ActivationFunction ReLu => reLu;
}