using UnityEngine;

public class Billboard : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player Model");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position, Vector3.up);
        transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
    }
}
