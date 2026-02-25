using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Globalization;

public class InvertorySystem : MonoBehaviour
{
    public List<Item> items = new List<Item>(5);

    Item selectedItem;

    public KeyCode Use1;

    public KeyCode Use2;

    public List<Image> slots = new List<Image>(5);

    public List<Image> hobarTiles = new List<Image>(5);

    private int currentIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectedItem = items[0];
        items[0] = null;
        items[1] = null;
        items[2] = null;
        items[3] = null;
        items[4] = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            selectItem(currentIndex, 0);
            Debug.Log("selected item 1, " + selectedItem.getName());
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            selectItem(currentIndex, 1);
            Debug.Log("selected item 2, " + selectedItem.getName());
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            selectItem(currentIndex, 2);
            Debug.Log("selected item 3, " + selectedItem.getName());
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            selectItem(currentIndex, 3);
            Debug.Log("selected item 4, " + selectedItem.getName());
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
           
            selectItem(currentIndex, 4);
            Debug.Log("selected item 5, " + selectedItem.getName());
        }

        if (selectedItem != null)
        {

            if (Input.GetKeyDown(Use1))
            {
                selectedItem.Use1();
            }

            if (Input.GetKeyDown(Use2))
            {
                selectedItem.Use2();
            }
        }

    }

    public Item getSelectedItem()
    {
        return selectedItem;
    }
    
    public int canAddItem()
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                return i;
            }
        }
        return -1;
    }

    public void addItem(Item item, int index)
    {
        items[index] = item;
        item.gameObject.SetActive(false);
        updateList();
    }

    private void updateList()
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] != null)
            {
                Debug.Log("updated sprite");
                slots[i].sprite = items[i].getImage();
            }
        }
    }

    private void selectItem(int currIndex, int nextIndex)
    {
        hobarTiles[currIndex].transform.localScale = Vector3.one;
        hobarTiles[nextIndex].transform.localScale = new Vector3(1.1679f, 1.1679f, 1.1679f);

        selectedItem = items[nextIndex];
        currentIndex = nextIndex;
    }
}
