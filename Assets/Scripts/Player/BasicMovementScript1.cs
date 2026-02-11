 using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BasicMovementScript : MonoBehaviour
{
    //Variable that controls our speed
    public float speed;

    //HAR HAR FIDDLE DEE DEE
    public Rigidbody rb;

    //velocittyyytytty
    private Vector3 velocity = Vector3.zero;

    //strength of the dash
    public float DashPower = 20;

    //cooldown on the dash (These should be in seconds according to their relevant programming.)
    public float DashCool = 0.2f;

    //How much time is currently left on the dash cooldown (These should be in seconds according to their relevant programming.) (This is a timer.)
    private float DashCoolTimeLeft = 0;

    //Whether you are currently in the action of dashing or not
    private bool IsDashing = false;

    //Time left until the dash is done (These should be in seconds according to their relevant programming.) (0.1f is temporary.) (This is a timer.)
    private float IsDashingTimeLeft = 0.1f;

    //How long IN TIME IN SECONDS the dash ITSELF AACCTTUUAALLLLYY lasts. (This should also probably be in seconds.) (This is a solid value.)
    public float DurationOfTheDash = 0.1f;

    //If you are touching a wall or not
    public bool OnWall = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        DashCoolTimeLeft -= Time.deltaTime;
        if (DashCoolTimeLeft < 0 )
        {
            DashCoolTimeLeft = 0;
        }

        IsDashingTimeLeft -= Time.deltaTime;
        if (IsDashingTimeLeft <= 0)
        {
            IsDashingTimeLeft = 0;
            IsDashing = false;
        }
        
       

        float VerticalInput = Input.GetAxisRaw("Vertical");
        float HorizontalInput = Input.GetAxisRaw("Horizontal");

        //The russians sought to stop the chinese invaision but they failed

        Vector3 moveVector = (transform.right * HorizontalInput + transform.forward * VerticalInput).normalized * speed;
        if (IsDashing == false)
        {
            velocity = Vector3.MoveTowards(velocity, moveVector, 1f);
        }
        rb.linearVelocity = new Vector3 (velocity.x, rb.linearVelocity.y, velocity.z);

        // !!IMPORTANT!! We need to re-do the movement so that you slowly slow down to a stop and your momentum can like carry through stuff and all that.

        /// Challenge # 1
        /// Create key inputs for all four directions
        /// Use the example code above to recreate the movement and remember: 
        /// Challenge # 2 
        /// 


        //float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //transform.Translate(horizontal, 0, vertical);

        if (Input.GetButtonDown("Jump") && OnGround())
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            if (IsDashing)
            {
                Debug.Log("DASH JUUUUUMP!!!");
                velocity += (transform.forward * DashPower);
            }
        }

        if (Input.GetButtonDown("Dash") && DashCoolTimeLeft <= 0)
        {
            //rb.AddForce(transform.forward * 50, ForceMode.Impulse);
            DashCoolTimeLeft = DashCool;
            if (moveVector == Vector3.zero)
            {
                velocity = transform.forward * DashPower;
            }
            else
            {
                velocity += moveVector.normalized * DashPower;
            }
            //The amount of time that it THINKS you are dashing is now equal to how long you will actually dash for.
            IsDashingTimeLeft = DurationOfTheDash;
            IsDashing = true;
            Debug.Log("IsDashing = true");
        }
    }

    bool OnGround()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 2);
    }

    //private IEnumerator Dash()
    //{
    //    IsDashing = true;
    //    float DashCool = Time.time;

    //    //start a cooldown
    //    // while the cooldown is not done, push player forward
    //    // once done, then stop dashing and continue walking like normal
    //}
}









