using System.Collections.Generic;
using UnityEngine;
/*
 * Drug database that is responsible for storing and retrieving the drug
 */
public class DrugRepository
{
    private readonly List<Drug> drugs = new();
    public void AddDrug(Drug drug)
    {
        drugs.Add(drug);

        Debug.Log($"Added {drug.Name}. Total drugs: {drugs.Count}");
    }
    public Drug GetDrugByIndex(int index)
    {
        if (index < 0 || index >= drugs.Count)
        {
            Debug.LogWarning("Index out of range");
            return null;
        }

        return drugs[index];
    }
}