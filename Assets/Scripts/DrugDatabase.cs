using System.Collections.Generic;
using UnityEngine;

public class DrugDatabase : MonoBehaviour
{
    public List<Drug> drugList;
    private void AddDrug(Drug drug)
    {
        if (drug.NDC.ToString("F0").Length == 11)
        {
            drugList.Add(drug);
        }
        else
        {
            Debug.Log("NDC is not 11 digits");
        }
    }

    public void CreateDrugData(InputFieldManager userInputs)
    {
        Drug newDrug = new Drug(userInputs.drugName, userInputs.drugStrength, userInputs.drugNDC);
        //Debug.Log(newDrug.Name + " " + newDrug.Strength + " " + newDrug.NDC);
        AddDrug(newDrug);
    }
    public Drug GetDrugByIndex(int index)
    {
        var temp = drugList[index];
        return temp;
    }
}