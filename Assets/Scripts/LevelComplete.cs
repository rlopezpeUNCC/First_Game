using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
   
    public void LoadNextLvl()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }
}
