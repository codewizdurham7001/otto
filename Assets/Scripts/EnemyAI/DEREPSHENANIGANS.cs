using UnityEngine;

public class DEREPSHENANIGANS : MonoBehaviour
{
    private Rigidbody rb;
    public float attackRadius;
    public float maxDistance;
    public LayerMask hitLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX;
        rb.constraints = RigidbodyConstraints.FreezeRotationY;
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        RaycastHit hitInfo;
        //Possibly not ideal method,. but easier (refering to hitLayer
        if(Physics.SphereCast(origin, attackRadius, direction, out hitInfo, maxDistance, hitLayer))
        {
            //Pouncing code
            Debug.DrawRay(origin, direction * maxDistance, Color.red);


        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
