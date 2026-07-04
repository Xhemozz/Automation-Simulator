[System.Serializable]

// Data thats used to construct the Drug object
public class Drug
{
    public string Name;
    public string Strength;
    public string NDC;
    public bool IsActive;

    public Drug(string name, string strength, string ndc)
    {
        Name = name;
        Strength = strength;
        NDC = ndc;
        IsActive = true;
    }
}
