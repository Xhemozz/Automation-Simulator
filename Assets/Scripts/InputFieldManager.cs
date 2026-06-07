using TMPro;
using UnityEngine;

public class InputFieldManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField strengthInput;
    public TMP_InputField ndcInput;

    public string drugName;
    public int drugStrength;
    public double drugNDC;

    public void ReadDrugName()
    {
        drugName = nameInput.text;
    }

    public void ReadDrugStrength()
    {
        drugStrength = int.Parse(strengthInput.text);
    }

    public void ReadDrugNDC()
    {
        drugNDC = double.Parse(ndcInput.text);
    }
}
