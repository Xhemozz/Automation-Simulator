using UnityEngine;
public class DrugSpawner : MonoBehaviour
{
    private const string DrugPrefabPath = "Pill";

    public GameObject SpawnDrug(Drug drug, Transform spawnPoint)
    {
        GameObject prefab = Resources.Load<GameObject>(DrugPrefabPath);

        if (prefab == null)
        {
            Debug.LogError($"Could not load prefab at Resources/{DrugPrefabPath}");
            return null;
        }

        GameObject obj = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        DrugComponent cmp = obj.GetComponent<DrugComponent>();

        if (cmp != null)
            cmp.Init(drug);

        return obj;
    }
}
