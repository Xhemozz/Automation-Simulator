
public enum PrescriptionState
{
    Success,
    InvalidName,
    InvalidDrug,
    InvalidQuantity
}
public class PrescriptionService
{
    public PrescriptionState CreatePrescription(
        string patient,
        string drug,
        string quantityText,
        out Prescription prescription)
    {
        prescription = null;

        if (string.IsNullOrWhiteSpace(patient))
            return PrescriptionState.InvalidName;

        if (string.IsNullOrWhiteSpace(drug))
            return PrescriptionState.InvalidDrug;

        if (!int.TryParse(quantityText, out int qty) || qty <= 0)
            return PrescriptionState.InvalidQuantity;

        prescription = new Prescription(patient, drug, qty);

        return PrescriptionState.Success;
    }
}
