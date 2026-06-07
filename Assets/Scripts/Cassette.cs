using Unity.Mathematics;
using UnityEngine;

public class Cassette : MonoBehaviour
{
    public DrugDatabase database;
    public DrugGameObjectCreator creator;

    public int cassetteID = 0;
    public int maximumCapacity = 5;

    public Transform spawnPoint;

    private bool isEmpty = true;
    private GameObject obj;
    private void Update()
    {
        if (database.drugList != null && database.drugList.Count > 0)
        {
            if (isEmpty)
            {
                var temp = database.GetDrugByIndex(cassetteID);
                obj = creator.CreateDrugObject(temp, spawnPoint);
                LoadDrugIntoCassette(obj);
                isEmpty = false;
            }
        }
    }

    private void LoadDrugIntoCassette(GameObject clone)
    {
        for (int i = 0; i < maximumCapacity; i++)
        {
            Instantiate(clone, spawnPoint.position, quaternion.identity);
        }
    }
}
