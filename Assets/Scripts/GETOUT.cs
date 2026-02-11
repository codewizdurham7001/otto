using UnityEngine;
using UnityEngine.SceneManagement;

public class GETOUT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void kys()
    {
        
        Application.Quit();
    }

    public void Getup()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
