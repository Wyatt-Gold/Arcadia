using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{

    public GameObject[] puzzlePieceHolder1;
    public GameObject[] puzzlePieceHolder2;
    public GameObject[] puzzlePieceHolder3;
    public GameObject[] puzzlePieceHolder4;

    public UnityEvent chickenDinner;

    public static int greenCounter;
    public static int redCounter;
    public static int blueCounter;
    public static int blackCounter;

    private void Awake(){
        greenArcade();
        redArcade();
        blueArcade();
        blackArcade();
    }

    public void Winner(){
        if(puzzlePieceHolder1[1].activeInHierarchy && puzzlePieceHolder2[2].activeInHierarchy && puzzlePieceHolder3[2].activeInHierarchy && puzzlePieceHolder4[1].activeInHierarchy){
            Debug.Log("You win!");
            chickenDinner.Invoke();
        }
    }

    public void loadTetris(){
        SceneManager.LoadScene(2);
    }

    public void loadSnake(){
        SceneManager.LoadScene(3);
    }

    public void loadPacman(){
        SceneManager.LoadScene(5);
    }

    public void loadBrickBreaker(){
        SceneManager.LoadScene(6);
    }
    public void greenArcade(){
        switch(greenCounter){
            case 0: 
                puzzlePieceHolder1[0].SetActive(true);
                puzzlePieceHolder1[1].SetActive(false);
                puzzlePieceHolder1[2].SetActive(false);
                break;
            case 1: 
                puzzlePieceHolder1[0].SetActive(false);
                puzzlePieceHolder1[1].SetActive(true);
                puzzlePieceHolder1[2].SetActive(false);
                break;
            case 2: 
                puzzlePieceHolder1[0].SetActive(false);
                puzzlePieceHolder1[1].SetActive(false);
                puzzlePieceHolder1[2].SetActive(true);
                break;
            case 3: 
                puzzlePieceHolder1[0].SetActive(true);
                puzzlePieceHolder1[1].SetActive(false);
                puzzlePieceHolder1[2].SetActive(false);
                greenCounter = 0;
                break;
            default:
                break;
        }
    }

    public void redArcade(){
        switch(redCounter){
            case 0: 
                puzzlePieceHolder2[0].SetActive(true);
                puzzlePieceHolder2[1].SetActive(false);
                puzzlePieceHolder2[2].SetActive(false);
                break;
            case 1: 
                puzzlePieceHolder2[0].SetActive(false);
                puzzlePieceHolder2[1].SetActive(true);
                puzzlePieceHolder2[2].SetActive(false);
                break;
            case 2: 
                puzzlePieceHolder2[0].SetActive(false);
                puzzlePieceHolder2[1].SetActive(false);
                puzzlePieceHolder2[2].SetActive(true);
                break;
            case 3: 
                puzzlePieceHolder2[0].SetActive(true);
                puzzlePieceHolder2[1].SetActive(false);
                puzzlePieceHolder2[2].SetActive(false);
                redCounter = 0;
                break;
            default:
                break;
        }
    }

    public void blueArcade(){
        switch(blueCounter){
            case 0: 
                puzzlePieceHolder3[0].SetActive(true);
                puzzlePieceHolder3[1].SetActive(false);
                puzzlePieceHolder3[2].SetActive(false);
                break;
            case 1: 
                puzzlePieceHolder3[0].SetActive(false);
                puzzlePieceHolder3[1].SetActive(true);
                puzzlePieceHolder3[2].SetActive(false);
                break;
            case 2: 
                puzzlePieceHolder3[0].SetActive(false);
                puzzlePieceHolder3[1].SetActive(false);
                puzzlePieceHolder3[2].SetActive(true);
                break;
            case 3: 
                puzzlePieceHolder3[0].SetActive(true);
                puzzlePieceHolder3[1].SetActive(false);
                puzzlePieceHolder3[2].SetActive(false);
                blueCounter = 0;
                break;
            default:
                break;
        }
    }

    public void blackArcade(){
        switch(blackCounter){
            case 0: 
                puzzlePieceHolder4[0].SetActive(true);
                puzzlePieceHolder4[1].SetActive(false);
                puzzlePieceHolder4[2].SetActive(false);
                break;
            case 1: 
                puzzlePieceHolder4[0].SetActive(false);
                puzzlePieceHolder4[1].SetActive(true);
                puzzlePieceHolder4[2].SetActive(false);
                break;
            case 2: 
                puzzlePieceHolder4[0].SetActive(false);
                puzzlePieceHolder4[1].SetActive(false);
                puzzlePieceHolder4[2].SetActive(true);
                break;
            case 3: 
                puzzlePieceHolder4[0].SetActive(true);
                puzzlePieceHolder4[1].SetActive(false);
                puzzlePieceHolder4[2].SetActive(false);
                blackCounter = 0;
                break;
            default:
                break;
        }
    }

}
