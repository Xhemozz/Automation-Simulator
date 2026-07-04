using UnityEngine;

// Service layer that crreates the medication
public class DrugService
{
    private readonly DrugRepository repository;
    private readonly DrugCreator creator;

    public DrugService(DrugRepository repo, DrugCreator creator)
    {
        repository = repo;
        this.creator = creator;
    }

    public bool CreateDrug(string name, string strength, string ndc)
    {

        Debug.Log($"repo null? {repository == null}");
        Debug.Log($"creator null? {creator == null}");
        if (string.IsNullOrWhiteSpace(name)) return false;
        if (string.IsNullOrWhiteSpace(strength)) return false;
        if (string.IsNullOrWhiteSpace(ndc)) return false;

        Drug drug = creator.CreateDrug(name, strength, ndc);
        repository.AddDrug(drug);

        return true;
    }
}
