using UnityEngine;

public class ShotgunItem : Item, IInteractable
{



    GameObject Player;
    InvertorySystem Inventory;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setName("Shotgun");
    }
    
    public override void Use1()
    {

    }
    
}
