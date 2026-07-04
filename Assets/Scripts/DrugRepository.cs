using System.Collections.Generic;
/*
 * Drug database that is responsible for storing and retrieving the drug
 */
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