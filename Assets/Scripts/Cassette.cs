using Unity.Mathematics;
using UnityEngine;
/*
 * Takes a drug from the database and uses it to fill a prescription
 */
public class Cassette : MonoBehaviour
{
    [SerializeField] private DrugSpawner spawner;
    [SerializeField] private Transform spawnpoint;

    private Drug loadedDrug;
    private int remaining;

    public void LoadDrug(Drug drug, int quantity)
    {
        loadedDrug = drug;
        remaining = quantity;
    }

    public void DispenseOne()
    {
        if (loadedDrug == null || remaining <= 0) return;

        spawner.SpawnDrug(loadedDrug, spawnpoint);
        remaining--;
    }

    public bool CanDispense() => loadedDrug != null && remaining > 0;
}
