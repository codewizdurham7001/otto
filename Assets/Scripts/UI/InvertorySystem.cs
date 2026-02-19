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

    private float deselectWidth = 50f;

    private float deselectHeight = 50f;

    private float selectWidth = 68.5434f;

    private float selectHeight = 65.1316f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectedItem = items[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            selectedItem = items[0];
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            selectedItem = items[1];
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            selectedItem = items[2];
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            selectedItem = items[3];
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            selectedItem = items[4];
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
        if (items.Count == 0)
        {
            return 0;
        }
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
}
