using UnityEngine;

public class ShotgunItem : Item, IInteractable
{



    GameObject Player;
    InvertorySystem Inventory;

    //temp del afrter we call invSys^
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setName("Shotgun");
    }
    
    public override void Use1()
    {
        if (Inventory.Shells > 0)
        {
            //do stuff animations + damage
            Inventory.Shells -= 1;
        }
        else
        {

        }
    }
    
}
