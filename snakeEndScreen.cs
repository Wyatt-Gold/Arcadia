using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;

public class snakeEndScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("loadScreen",3);
    }

    public void loadScreen(){
        SceneManager.LoadScene(1);
    }
}
