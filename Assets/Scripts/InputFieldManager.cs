using TMPro;
using UnityEngine;

public class InputFieldManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField strengthInput;
    [SerializeField] private TMP_InputField ndcInput;

    [SerializeField] private DrugRepositoryManager repositoryManager;
    [SerializeField] private DrugCreator creator;

    private DrugService drugService;

    private void Start()
    {
        if (repositoryManager.Repository == null) Debug.Log("Repo is Null");
        Debug.Log("Repo USED (UI): " + repositoryManager.Repository.GetHashCode());
        drugService = new DrugService(repositoryManager.Repository, creator);
    }

    public void OnSubmit()
    {
        bool success = drugService.CreateDrug(nameInput.text, strengthInput.text, ndcInput.text);

        if (!success) Debug.LogWarning("Invalid Input");
        else Debug.Log("Drug created successfully");
    }
}
