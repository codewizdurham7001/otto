using UnityEngine;

public class DEREPSHENANIGANS : MonoBehaviour
{
    private Rigidbody rb;
    public float attackRadius;
    public float maxDistance;
    public LayerMask hitLayer;
    public float ChaseSpeed;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        RaycastHit hitInfo;
        //Possibly not ideal method, but easier (refering to hitLayer)
        if (Physics.SphereCast(origin, maxDistance, direction, out hitInfo, maxDistance, hitLayer))
        {
            transform.position += transform.forward * ChaseSpeed * Time.deltaTime;
            transform.LookAt(Player.transform.position);
            if (Physics.SphereCast(origin, attackRadius, direction, out hitInfo, maxDistance, hitLayer))
            {
                //Pouncing code
                Debug.DrawRay(origin, direction * maxDistance, Color.red);

                rb.constraints = RigidbodyConstraints.None;
                transform.LookAt(Player.transform);
                rb.AddForce(Vector3.forward, ForceMode.Impulse);
            }


        }
     
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
