//**THIS CODE WAS/IS WRITTEN BY Daniel Snytkin, AKA Daniel_4_Fun or Daniel-4-Fun**//
using TMPro;
using UnityEngine;

public class CalculatorPrintManager : MonoBehaviour
{
    public TMP_InputField inputField;

    public TextMeshProUGUI result;
    public float number1 = 0f;
    public float number2 = 0f;
    public string NumberOperation;
    
    //**Print the numbers on the screen text (can be assigned in the button inspector)**//
    public void PrintButton(string text)
    {
        inputField.text += text.ToString();
    }

    //**Operations**//
    public void Addition()
    {
        number1 = float.Parse(inputField.text);
        NumberOperation = ("+");
        inputField.text = "";
    }
    public void Subtraction()
    {
        number1 = float.Parse(inputField.text);
        NumberOperation = ("-");
        inputField.text = "";
    }
    public void Division()
    {
        number1 = float.Parse(inputField.text);
        NumberOperation = ("/");
        inputField.text = "";
    }
    public void Multiplication()
    {
        number1 = float.Parse(inputField.text);
        NumberOperation = ("*");
        inputField.text = "";
    }
    //**Remove the numbers we have (backspace but better)**//
    public void OnClickRemoveButton()
    {
        inputField.text = "";
    }

    //**Print the result**//
    public void PrintTheResult()
    {
        float result = 0f;
        number2 = float.Parse(inputField.text);
        string operation = NumberOperation;

        switch(operation)
        {
            case "+":
                result = number1 + number2;
                inputField.text = result.ToString();
                break;
            case "-":
                result = number1 - number2;
                inputField.text = result.ToString();
                break;
            case "/":
                result = number1 / number2;
                inputField.text = result.ToString(); 
                break;
            case "*":
                result = number1 * number2;
                inputField.text = result.ToString();
                break;
        }
    }
    
}
