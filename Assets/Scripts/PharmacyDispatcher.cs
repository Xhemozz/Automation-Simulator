using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Centralized Dispatcher that starts the simulation for filling prescriptions
public class PharmacyDispatcher : MonoBehaviour
{
    [SerializeField] private List<Cassette> cassettes;

    private readonly Queue<Prescription> queue = new();
    private GameBootstrapper bootstrapper;
    private bool isProcessing;

    public void Initilize(GameBootstrapper b)
    {
        bootstrapper = b;
    }
    public void EnqueuePrescription(Prescription prescription)
    {
        queue.Enqueue(prescription);
    }

    public void StartProcessing()
    {
        if (!isProcessing)
            StartCoroutine(ProcessQueue());
    }

    private IEnumerator ProcessQueue()
    {
        isProcessing = true;

        while (queue.Count > 0)
        {
            Prescription rx = queue.Dequeue();

            var drug = bootstrapper.Repository.GetDrugByName(rx.drugName);

            if (drug == null)
            {
                Debug.LogWarning($"Drug not found: {rx.drugName}");
                continue;
            }

            Cassette cassette = GetCassette(drug);

            if (cassette == null)
            {
                Debug.LogWarning($"No cassette mapped for: {rx.drugName}");
                continue;
            }

            cassette.LoadDrug(drug, rx.quantity);

            for (int i = 0; i < rx.quantity; i++)
            {
                cassette.DispenseOne();
                yield return new WaitForSeconds(0.1f);
            }
        }

        isProcessing = false;
    }

    private Cassette GetCassette(Drug drug)
    {
        return cassettes.Find(c => c != null);
    }

    public Prescription[] GetQueueSnapshot()
    {
        return queue.ToArray();
    }
}