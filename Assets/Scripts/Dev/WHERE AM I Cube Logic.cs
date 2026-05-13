using UnityEngine;

public class WHEREAMICubeLogic : MonoBehaviour
{
    public GameObject Me;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Me.transform.position);
    }
}
