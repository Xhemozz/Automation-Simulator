
public enum PrescriptionState
{
    Success,
    InvalidName,
    InvalidDrug,
    InvalidQuantity
}
public class PrescriptionService
{
    private readonly PrescriptionQueue prescriptionQueue;

    public PrescriptionService(PrescriptionQueue scriptQueue)
    {
        prescriptionQueue = scriptQueue;
    }

    public PrescriptionState CreatePrescription(string nameInput, string drugInput, string quantityInput)
    {
        if (string.IsNullOrWhiteSpace(nameInput)) return PrescriptionState.InvalidName;
        if (string.IsNullOrWhiteSpace(drugInput)) return PrescriptionState.InvalidDrug;
        if (!int.TryParse(quantityInput, out int quantity)) return PrescriptionState.InvalidQuantity;

        Prescription prescription = new Prescription(nameInput, drugInput, quantity);

        prescriptionQueue.AddPrescriptionToQueue(prescription);

        return PrescriptionState.Success;
    }
}
