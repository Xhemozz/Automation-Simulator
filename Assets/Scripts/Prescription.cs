using UnityEngine;
/*
 * Has the patients name and drug
 */
public class Prescription
{
    public string patientName;
    public string drugName;
    public int quantity;

    public Prescription(string name, string drugName, int quantity)
    {
        this.patientName = name;
        this.drugName = drugName;
        this.quantity = quantity;
    }
}
