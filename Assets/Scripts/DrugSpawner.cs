using UnityEngine;

// Spawns medication in the scene
public class DrugSpawner : MonoBehaviour
{
    [SerializeField] private GameObject drugPrefab;

    public GameObject SpawnDrug(Drug drug, Transform spawnPoint)
    {
        if (drugPrefab == null)
        {
            Debug.LogError("DrugSpawner: Prefab not assigned.");
            return null;
        }

        GameObject obj = Instantiate(
            drugPrefab,
            spawnPoint.position,
            Quaternion.identity
        );

        if (obj.TryGetComponent(out DrugComponent cmp))
        {
            cmp.Init(drug);
        }

        return obj;
    }
}