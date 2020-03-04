using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonPlay()
    {
        SceneManager.LoadScene("Game");

        }
    public void ButtonCredits()
    {
        SceneManager.LoadScene("Credits");

    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}

