using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundFX : MonoBehaviour
{
    public AudioSource Speaker;

    public AudioClip[] Clips;

    public bool OnGround;
    private void OnCollisionEnter(Collision collision)
    {
        //if colliding with the game object with ground tag, then set it to true
        if (collision.gameObject.tag == "Ground")
        {
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //if colliding with the game object with ground tag, then set it to true
        if (collision.gameObject.tag == "Ground")
        {
           
        }
    }

    public void FootSteps()
    {
        //if pooperp is On ground, then play the audio speaker
        if (OnGround)
        {

        }
    }

    private void Update()
    {
        //If you press the W or Up Arrow Key, then use the FootSteps function
        if (Input.GetKeyDown(KeyCode.W))
        {
           
        }
    }
}
