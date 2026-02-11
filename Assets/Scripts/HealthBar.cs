using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //The accosiated player
    public GameObject Player;
    //THe accosiated HealthManager
    private HealthManager Manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Manager = Player.GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(Manager.CurrentHealth/Manager.MaxHealth, 1, 1);
    }
}
