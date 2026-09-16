using UnityEngine;

public class AttractiveBreadItem : Item , IInteractable
{

    GameObject myPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setName("Bread");
        myPlayer = GameObject.Find("Player Model");
    }

    public override void Use2()
    {
        HealthManager healthManager = myPlayer.GetComponent<HealthManager>();
        if (healthManager.CurrentHealth < healthManager.MaxHealth)
        {
            healthManager.Heal(5);
            Inventory = myPlayer.GetComponent<InvertorySystem>();
            Inventory.remove();
        }
    }
}
