using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.AssetImporters;
using UnityEngine;

public class Cassette : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField]private DrugRepositoryManager repository;
    [SerializeField]private DrugSpawner spawner;
    [SerializeField]private Transform spawnpoint;
    
    [Header("Configs")]
    [SerializeField] private int cassetteIndex = 0;
    [SerializeField] private int maximumCapacity = 30;

    private bool isLoaded = false;

    public void Load()
    {
        if (isLoaded) return;

        Drug drug = repository.Repository.GetDrugByIndex(cassetteIndex);

        if(drug == null)
        {
            Debug.LogWarning("Cassette: No drug found at index " + cassetteIndex);
            return;
        }

        SpawnDrugs(drug);

        isLoaded = true;
    }

    private void SpawnDrugs(Drug drug)
    {
        for(int i = 0; i < maximumCapacity; i++)
        {
            spawner.SpawnDrug(drug, spawnpoint);
        }
    }
}
