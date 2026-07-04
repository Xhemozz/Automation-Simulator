using UnityEngine;
using TMPro;

public class QueueDisplayUI : MonoBehaviour
{
    [SerializeField] private PharmacyDispatcher dispatcher;
    [SerializeField] private TMP_Text queueText;

    private void Update()
    {
        RefreshUI();
    }

    private void RefreshUI()
    {
        var queue = dispatcher.GetQueueSnapshot();

        queueText.text = BuildText(queue);
    }

    private string BuildText(Prescription[] queue)
    {
        if (queue.Length == 0)
            return "Queue: Empty";

        string result = "Prescription Queue:\n";

        foreach (var rx in queue)
        {
            result += $"- {rx.patientName} | {rx.drugName} | x{rx.quantity}\n";
        }

        return result;
    }
}