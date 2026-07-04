using TMPro;
using UnityEngine;

// Manages user input through Input Fields
public class InputFieldManager : MonoBehaviour
{
    [Header("Drug UI")]
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField strengthInput;
    [SerializeField] private TMP_InputField ndcInput;

    [Header("Prescription UI")]
    [SerializeField] private TMP_InputField patientInput;
    [SerializeField] private TMP_InputField drugInput;
    [SerializeField] private TMP_InputField quantityInput;

    public void OnSubmitDrug()
    {
        bool success = GameBootstrapper.Instance.DrugService.CreateDrug(
            nameInput.text,
            strengthInput.text,
            ndcInput.text
        );

        Debug.Log(success ? "Drug created" : "Invalid drug input");

        ClearDrugFields();
    }

    public void OnSubmitPrescription()
    {
        Debug.Log(GameBootstrapper.Instance == null);
        var service = GameBootstrapper.Instance.PrescriptionService;
        var dispatcher = GameBootstrapper.Instance.GetComponent<PharmacyDispatcher>();

        var result = service.CreatePrescription(
            patientInput.text,
            drugInput.text,
            quantityInput.text,
            out Prescription prescription
        );

        if (result != PrescriptionState.Success)
        {
            Debug.LogWarning(result);
            return;
        }

        GameBootstrapper.Instance.Dispatcher.EnqueuePrescription(prescription);

        ClearPrescriptionFields();
    }

    private void ClearDrugFields()
    {
        nameInput.text = "";
        strengthInput.text = "";
        ndcInput.text = "";
    }

    private void ClearPrescriptionFields()
    {
        patientInput.text = "";
        drugInput.text = "";
        quantityInput.text = "";
    }
}