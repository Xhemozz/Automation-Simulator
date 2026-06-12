using System.Collections.Generic;
using UnityEngine;
/*
 * Puts patients into a queue so their medication gets filled
 */
public class PrescriptionQueue
{
    public readonly Queue<Prescription> patients = new();

    //TODO: Queue up patients and use their drug information to get a cassette that fills the order

    public void AddPatientToQueue(Prescription patient)
    {
        patients.Enqueue(patient);
        Debug.Log($"{patient.patientName} is added to the queue");
    }
}
