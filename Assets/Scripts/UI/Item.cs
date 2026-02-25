using UnityEngine;

public class Item : MonoBehaviour , IInteractable
{
    public string itemName;

    public Sprite image;

    public GameObject runwayModel;

    GameObject Player;
    InvertorySystem Inventory;

    public void setName(string name)
    {
        itemName = name;
    }
    

    // Update is called once per frame
    public void SetImage(Sprite image)
    {
        this.image = image;
    }

    public string getName()
    {
        return itemName;
    }

    public Sprite getImage()
    {
        return image;
    }

    void IInteractable.Interact()
    {
        Inventory = GameObject.Find("Player Model").GetComponent<InvertorySystem>();
        int indexToAdd = Inventory.canAddItem();
        if (indexToAdd != -1) 
        {
            Inventory.addItem(this, indexToAdd);
        }
    }

    public void Use1()
    {
        Debug.Log("Yo what's up guys! It's me Joe! Your item file didn't override Use1!");
    }

    public void Use2()
    {
        Debug.Log("Yo what's up guys! It's me Joe! Your item file didn't override Use2!");
    }
}
