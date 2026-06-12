using UnityEngine;
/*
 * Wrapper class for the Drug Repository to hook up in the inspector
 */
public class DrugRepositoryManager : MonoBehaviour
{
    public DrugRepository Repository;

    private void Awake()
    {
        Repository = new DrugRepository();
        
        Debug.Log("Repo CREATED: " + Repository.GetHashCode());
    }
}
