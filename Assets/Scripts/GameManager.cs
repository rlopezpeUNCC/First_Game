using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 1f;
    public PlayerMovement movement;
    public GameObject winUI;
    public Text hint;
    public Canvas checks;    
    public Camera cam;
    public Dropdown miniGameAnswer;
    public Text checkResults;
    public Canvas results;
    public void CompleteLevel (){
        movement.enabled = false;  
        hint.enabled = false; 
        winUI.SetActive(true);
        
    }
    
    public void checkAnswer(){        
        Color newColor = new Color(204f, cam.backgroundColor.g-.1f, cam.backgroundColor.b-.1f);           
        if (miniGameAnswer.value.Equals(1)){            
            checkResults.text = "SUCCESS!";
            checkResults.color = Color.green;
        } else {
            checkResults.text = "FAILED!";
            checkResults.color = Color.red;
            movement.fowardForce = 10000f;           
            cam.backgroundColor = newColor;            
        }
        Invoke("outOfTime", 3f);
        closeChecks();    
        results.gameObject.SetActive(true);
        Invoke("closeResults", 1.5f);        
    }
    void closeChecks(){
        checks.gameObject.SetActive(false);
    }
    void outOfTime(){
        Color newColor = new Color(204f, cam.backgroundColor.g-.1f, cam.backgroundColor.b-.1f);
        if (true){
            miniGameAnswer.gameObject.SetActive(false);
            checkResults.text = "OUT OF TIME!";
            checkResults.color = Color.red;
            movement.fowardForce = 10000f;           
            cam.backgroundColor = newColor;     
        }
    }

    void closeResults(){
        checkResults.enabled = false;
    }

    public void checkPointReached (){        
        checks.gameObject.SetActive(true);        
    }
    public void EndGame()    
    {
        if (gameOver == false){            
            gameOver = true;            
            Invoke("Restart", restartDelay);
        }
    }
    
    public void closeHint() {
        hint.enabled = false;
    }

    void Restart (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
