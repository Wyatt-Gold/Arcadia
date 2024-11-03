using UnityEngine;
using UnityEngine.SceneManagement;

public class BBWinScene : MonoBehaviour
{
    private void Awake(){
        Invoke("loadPlay", 2);
    }
    private void loadPlay(){
        SceneManager.LoadScene(1);
    }
}
