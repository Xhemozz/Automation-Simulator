using UnityEngine;

public class DrugCreator: MonoBehaviour
{
    public Drug CreateDrug(string name, float strength, string ndc)
    {
        return new Drug(name, strength, ndc);
    }
}
