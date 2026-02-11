using UnityEngine;

public class AttractiveBreadItem : Item , IInteractable
{

    GameObject Player;
    InvertorySystem Inventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setName("Bread");
    }

    public void Use1()
    {
        HealthManager healthManager = GameObject.Find("Player Model").GetComponent<HealthManager>();
        healthManager.Heal(5);
    }
}
