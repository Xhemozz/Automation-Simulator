using UnityEngine;

public class DrugService
{
    private readonly DrugRepository repository;
    private readonly DrugCreator creator;

    public DrugService(DrugRepository repository, DrugCreator creator)
    {
        this.repository = repository;
        this.creator = creator;
    }

    public bool CreateDrug(string name, string strengthText, string ndc)
    {
        if (string.IsNullOrWhiteSpace(name)) return false;
        if (string.IsNullOrWhiteSpace(ndc)) return false;
        if (ndc.Length != 11) return false;

        if (!float.TryParse(strengthText, out float strength)) return false;

        Drug drug = creator.CreateDrug(
            name.Trim(),
            strength,
            ndc.Trim()
        );

        repository.AddDrug(drug);

        return true;
    }
}
