using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class HealthManager : MonoBehaviour
{
    //Reference for Movement Script
    private BasicMovementScript MovementReference;
    //
    
    //Players maximum health
    public float MaxHealth = 20;
    //Players current health
    public float CurrentHealth = 20;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MovementReference = GetComponent<BasicMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        if (CurrentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Heal(int amount)
    {
        CurrentHealth += amount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EssenceOfPain>() != null)
        {
            if (MovementReference.IsDashing == false)
            {            
                ///Add Invincibility Frames at some point in some way, I think.
                CurrentHealth -= collision.gameObject.GetComponent<EssenceOfPain>().AttackPower;
            }
            /*///Add Invincibility Frames at some point in some way, I think.
            CurrentHealth -= collision.gameObject.GetComponent<EssenceOfPain>().AttackPower;*/
        }
    }

 

}
