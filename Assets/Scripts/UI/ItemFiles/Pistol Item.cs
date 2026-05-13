using UnityEngine;

public class PistolItem : Item, IInteractable
{
    private int cooldown;
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setName("Pistol");
        setAmmo(ammoTypes.Pistol); 
    }

    public override void Use1()
    {
        if (cooldown == 0) 
        {
            Ray detector = new Ray(Player.transform.position, Player.transform.forward);
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
                }
            }
        }
    }
}
