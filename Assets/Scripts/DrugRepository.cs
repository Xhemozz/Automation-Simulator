using System.Collections.Generic;
// Holds all medication and retrives medications by name
public class DrugRepository
{
    private readonly Dictionary<string, Drug> drugs = new();

    public void AddDrug(Drug drug)
    {
        if (drug == null || string.IsNullOrWhiteSpace(drug.Name))
            return;

        drugs[drug.Name] = drug;
    }

    public Drug GetDrugByName(string name)
    {
        drugs.TryGetValue(name, out Drug drug);
        return drug;
    }
}