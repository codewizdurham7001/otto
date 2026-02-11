using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float ChaseSpeed;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        //* Type Hunt() function here, within the parenthesis put variable: Player *
        Hunt(Player);
    }

    public void Hunt(GameObject Object)
    {
        //* Use transform.lookAt() here within the parenthesis put variable: Object.transform.position *
        transform.position += transform.forward * ChaseSpeed * Time.deltaTime;
        transform.LookAt(Object.transform.position);
    }
}
