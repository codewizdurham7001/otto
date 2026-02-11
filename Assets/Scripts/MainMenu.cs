using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        //* here uses SceneManager.LoadScene(), in the parenthesis type: 1 * 
        SceneManager.LoadScene(1);
    }
}
