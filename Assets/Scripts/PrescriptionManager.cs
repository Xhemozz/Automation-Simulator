using UnityEngine;

public class PrescriptionManager : MonoBehaviour
{
    public PrescriptionQueue queue;

    private void Awake()
    {
        queue = new PrescriptionQueue();
    }
}
