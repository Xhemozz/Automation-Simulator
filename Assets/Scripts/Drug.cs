
[System.Serializable]
public class Drug
{
    public string Name;
    public float Strength;
    public string NDC;
    public bool IsActive;

    public Drug(string name, float strength, string ndc)
    {
        Name = name;
        Strength = strength;
        NDC = ndc;
        IsActive = true;
    }
}
