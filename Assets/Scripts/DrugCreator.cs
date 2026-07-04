// Creates the drug object with user input
public class DrugCreator
{
    public Drug CreateDrug(string name, string strength, string ndc)
    {
        return new Drug(name, strength, ndc);
    }
}
