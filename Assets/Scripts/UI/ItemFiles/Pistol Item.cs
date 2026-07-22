using UnityEngine;
using System.Collections;

public class PistolItem : Item, IInteractable
{
    private int cooldown;
    public GameObject player;
    private LineRenderer bulletLine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletLine = GetComponent<LineRenderer>();
        player = GameObject.FindWithTag("Player");
        setName("Pistol");
        setAmmo(ammoTypes.Pistol);
    }

    public override void Use1()
    {
        if (cooldown == 0) 
        {

           

            Ray detector = new Ray(player.transform.position, player.transform.forward);
            Debug.DrawRay(player.transform.position, player.transform.forward * 100, Color.yellow, 1f);
            Debug.Log("shots fired!");


            

            if (Physics.Raycast(detector,out RaycastHit hit,100))
            {
                Debug.Log("Pistol Hit Something");
                Debug.Log(hit.collider.tag);
                if (hit.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Pistol Hit an enemy");
                    EnemyHealth HP = (hit.collider.GetComponent<EnemyHealth>());
                    HP.Health -= 10;

                    StartCoroutine(ShowTracer(hit.collider.transform.position));
                }
            }
        }
        //Need to switch coroutine to function with timer
        IEnumerator ShowTracer(Vector3 hitPosition)
        {
            bulletLine.SetPosition(0, transform.position);
            bulletLine.SetPosition(1, hitPosition);
            bulletLine.enabled = true;
            print("tracer enabled");
            yield return new WaitForSeconds(0.1f);
            bulletLine.enabled = false;
        }
    }
}
