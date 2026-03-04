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

    public override void Use2()
    {
        HealthManager healthManager = GameObject.Find("Player Model").GetComponent<HealthManager>();
        if (healthManager.CurrentHealth < healthManager.MaxHealth)
        {
            healthManager.Heal(5);
            Inventory = GameObject.Find("Player Model").GetComponent<InvertorySystem>();
            Inventory.remove();
        }
    }
}
