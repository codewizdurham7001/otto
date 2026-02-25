using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    //This variables is for checking if we can interact with an object
    public bool canInteract;
    //This variable is for checking if we are currently interacting with an object
    public bool isInteracting;

    //This variable is for keeping track of what object we are looking at !
    public Collider InteractableObject;

    //this variable is for keeping track of what key we are assigning to be our interact button
    public KeyCode interactKeyCode;

    //Otto here, I am asuming that this is the length that you can reach.
    public float length = 2.5f;

    private void Update()
    {
        //Calls the DrawDetector method
        DrawDetector();
        
    }

    //A custom method created for detecting Interacatable objects
    public void DrawDetector()
    {
        //Create a Ray variable and have it start from the player, and facing forward
        Ray detector = new Ray(transform.position, transform.forward);

        //Making sure its false if it shouldnt be true
        canInteract = false;

        //If my Raycast
        if (Physics.Raycast(detector, out RaycastHit hit, length))
        {
            if (hit.collider.tag == "Interactable")
            {
                canInteract = true;
                InteractableObject = hit.collider;
                if (Input.GetKeyDown(interactKeyCode))
                {
                    hit.collider.GetComponent<IInteractable>().Interact();
                }
            }
            

            if(hit.collider.tag == "ItemObject")
            {
                canInteract = true;
                InteractableObject = hit.collider;
                if (Input.GetKeyDown(interactKeyCode))
                {
                    hit.collider.GetComponent<IInteractable>().Interact();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.forward);
    }

}
