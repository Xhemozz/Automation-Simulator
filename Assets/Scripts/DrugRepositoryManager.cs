using UnityEngine;

public class DrugRepositoryManager : MonoBehaviour
{
    public DrugRepository Repository { get; private set; }

    private void Awake()
    {
        Repository = new DrugRepository();

        Debug.Log("Repo CREATED: " + Repository.GetHashCode());
    }
}
