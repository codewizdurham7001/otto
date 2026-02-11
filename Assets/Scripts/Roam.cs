using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript : MonoBehaviour
{
    public NavMeshAgent Source2;
    public Transform Player;
    public LayerMask Ground;
    public LayerMask PlayerMask;
    public Vector3 Destination;
    public float DestinationDistance;
    public float AttackSpeed;
    public float Vision;
    public float Reach;
    private bool DestinationSet;
    private bool PreviouslyAttacked;
    private bool PlayerWithinDetectionRange;
    private bool PlayerWithinAttackRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
