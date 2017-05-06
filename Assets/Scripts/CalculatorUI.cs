using UnityEngine;
using UnityEngine.UI;

public class CalculatorUI: MonoBehaviour
{
    #region Properties

    private string aNumber;
    private string bNumber;

    [SerializeField]
    private Text result;

    //Hidden
    private bool romanOutpout;

    #endregion

    private Calculator calculator;

    #region Unity functions

    private void Awake()
    {
        calculator = new Calculator(new NumberParser());
    }

    #endregion

    #region Buttons functions

    public void Sum()
    {
        UpdateResultField(calculator.Sum(aNumber, bNumber, romanOutpout));
    }

    public void Substract()
    {
        UpdateResultField(calculator.Substract(aNumber, bNumber, romanOutpout));
    }

    public void RomanOutpout(bool romanOutpout)
    {
        this.romanOutpout = romanOutpout;
    }

    public void ANumber(string aNumber)
    {
        this.aNumber = aNumber;
    }

    public void BNumber(string bNumber)
    {
        this.bNumber = bNumber;
    }

    private void UpdateResultField(string resultValue)
    {
        result.text = resultValue;
    }

    #endregion
}
