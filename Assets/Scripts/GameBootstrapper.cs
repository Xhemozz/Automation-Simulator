using UnityEngine;

// Singleton to initilize all services at start up
public class GameBootstrapper : MonoBehaviour
{
    public static GameBootstrapper Instance { get; private set; }

    public DrugRepository Repository { get; private set; }
    public DrugService DrugService { get; private set; }
    public PrescriptionService PrescriptionService { get; private set; }

    public PharmacyDispatcher Dispatcher { get; private set; }

    private DrugCreator creator;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // Initilizes all services
        Repository = new DrugRepository();
        creator = new DrugCreator();

        DrugService = new DrugService(Repository, creator);
        PrescriptionService = new PrescriptionService();

        Dispatcher = FindAnyObjectByType<PharmacyDispatcher>();
        Dispatcher.Initilize(this);
    }
}