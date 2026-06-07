
[System.Serializable]
public class Drug
{
    public string Name;
    public int Strength;
    public double NDC;
    public bool IsActive;

    public Drug(string name, int strength, double ndc)
    {
        Name = name;
        Strength = strength;
        NDC = ndc;
        IsActive = true;
    }
}
