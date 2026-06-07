using UnityEngine;

public class DrugGameObjectCreator : MonoBehaviour
{
    public GameObject CreateDrugObject(Drug drug, Transform parent)
    {
        GameObject obj = Instantiate(Resources.Load("Pill", typeof(GameObject)), parent) as GameObject;
        DrugComponent cmp = obj.GetComponent<DrugComponent>();
        cmp.SetData(drug);
        return obj;
    }
}