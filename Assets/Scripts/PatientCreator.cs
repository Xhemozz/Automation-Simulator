using UnityEngine;

public class PatientCreator: MonoBehaviour
{
    public Prescription NewPatient(string patientName, string patientDrug, int quantity)
    {
        return new Prescription(patientName, patientDrug, quantity);
    }
}
