using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    //Players maximum health
    public float MaxHealth = 20;
    //Players current health
    public float CurrentHealth = 20;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            CurrentHealth -= collision.gameObject.GetComponent<EssenceOfPain>().AttackPower;
        }
    }

 

}
