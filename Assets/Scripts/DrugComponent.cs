using UnityEngine;
/*
 * Wrapper class for the Drug object to attach to a game object
 */
public class DrugComponent : MonoBehaviour
{
    public Drug drugData;
    public void Init(Drug data)
    {
        drugData = data;
    }
}

