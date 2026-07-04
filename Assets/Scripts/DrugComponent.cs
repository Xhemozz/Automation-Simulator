using UnityEngine;

// Wrapper class to attach to pill object in the scene
public class DrugComponent : MonoBehaviour
{
    public Drug drugData;
    public void Init(Drug data)
    {
        drugData = data;
    }
}

