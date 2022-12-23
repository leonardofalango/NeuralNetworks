using System;

namespace NeuralNetwork.Exceptions;

public class InvalidParameterSizeExeception : System.Exception
{
    public override string Message => 
        "O vetor de inputs não possui o mesmo tamanho";
}