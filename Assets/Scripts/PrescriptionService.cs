
public class PrescriptionService
{
    private readonly PrescriptionQueue prescriptionQueue;
    private readonly PatientCreator patientCreator;

    public PrescriptionService(PrescriptionQueue scriptQueue, PatientCreator creator)
    {
        this.prescriptionQueue = scriptQueue;
        this.patientCreator = creator;
    }

    public bool CreatePrescription(string nameInput, string drugInput, string quantityInput)
    {
        if (string.IsNullOrWhiteSpace(nameInput)) return false;
        if (string.IsNullOrWhiteSpace(drugInput)) return false;
        if (!int.TryParse(quantityInput, out int quantity)) return false;

        Prescription prescription = new Prescription(nameInput, drugInput, quantity);

        prescriptionQueue.AddPatientToQueue(prescription);

        return true;
    }
}
