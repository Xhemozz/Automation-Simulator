using UnityEngine;

public class DrugRepositoryManager : MonoBehaviour
{
    public DrugRepository Repository;

    private void Awake()
    {
        Repository = new DrugRepository();
    }
}
