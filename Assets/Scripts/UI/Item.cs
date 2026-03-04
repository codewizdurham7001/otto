using UnityEngine;

public class Item : MonoBehaviour , IInteractable
{
    public string itemName;

    public Sprite image;

    public bool requiresAmmo;

    public GameObject viewModel;

    GameObject Player;
    InvertorySystem Inventory;

    public void setName(string name)
    {
        itemName = name;
    }
    

    // Update is called once per frame
    public void setImage(Sprite image)
    {
        this.image = image;
    }

    public void setAmmoRequirement()
    {
        requiresAmmo = false;
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

    public virtual void Use1()
    {
        Debug.Log("Yo what's up guys! It's me Joe! Your item file didn't override Use1!");
    }

    public virtual void Use2()
    {
        Debug.Log("Yo what's up guys! It's me Joe! Your item file didn't override Use2!");
    }
}
