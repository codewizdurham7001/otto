using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Implementing the interface means we have to call on the custom methods that were made in it!
public class PickUpScript : MonoBehaviour, IInteractable
{
    //This variable stores a transform that can be used to place things
    public Transform hold;

    //this variable stores true or false
    public bool PickedUp;

    //This is the contents of the custom method
    void IInteractable.Interact()
    {
        //Set variable to true
        this. PickedUp = true;
    }

    private void Update()
    {
        //if pickedup is true
        if (this.PickedUp == true)
        {
            //Set this postion to the positon of the GoToLocation variable
            this.transform.position = hold.position;
        }
        if (this.PickedUp == true & Input.GetKey(KeyCode.Q))
        {
            this.transform.position = this.transform.position;
            this.transform.SetParent(this.transform);
            this.PickedUp = false;
        }
    }
}
