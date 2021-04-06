using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    public GameManager gameManager;
    public void ButtonClicked() {
       gameManager.checkAnswer();
    }
}
