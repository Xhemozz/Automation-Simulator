using TMPro;
using UnityEngine;

/*
 * Handles user input from UI and uses that information to make the drug
 */
public class InputFieldManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField strengthInput;
    [SerializeField] private TMP_InputField ndcInput;

    [SerializeField] private TMP_InputField patientName;
    [SerializeField] private TMP_InputField drugName;
    [SerializeField] private TMP_InputField quantity;

    [SerializeField] private DrugRepositoryManager repositoryManager;
    [SerializeField] private DrugCreator creator;

    [SerializeField] private PrescriptionManager scriptService;

    private DrugService drugService;
    private PrescriptionService prescriptionService;

    private PrescriptionState currentState;

    private void Start()
    {
        if (repositoryManager.Repository == null) Debug.Log("Repo is Null");
        Debug.Log("Repo USED (UI): " + repositoryManager.Repository.GetHashCode());
        drugService = new DrugService(repositoryManager.Repository, creator);

        prescriptionService = new PrescriptionService(scriptService.queue);
    }

    public void OnSubmit()
    {
        bool success = drugService.CreateDrug(nameInput.text, strengthInput.text, ndcInput.text);

        if (!success) Debug.LogWarning("Invalid Input");
        else Debug.Log("Drug created successfully");
    }

    public void SubmitPrescription()
    {
        if (currentState == PrescriptionState.Success)
            prescriptionService.CreatePrescription(
            patientName.text, drugName.text, quantity.text);
        else
            Debug.Log("Prescription is invalid");
    }
}
