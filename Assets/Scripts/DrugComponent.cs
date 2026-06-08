using UnityEngine;

public class DrugComponent : MonoBehaviour
{
    public Drug drugData;
    public void Init(Drug data)
    {
        drugData = data;
    }
}

