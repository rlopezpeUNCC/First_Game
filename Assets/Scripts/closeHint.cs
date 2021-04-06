
using UnityEngine;

public class closeHint : MonoBehaviour
{
    public GameManager gameManager;
void OnTriggerEnter()
    {
        gameManager.closeHint();
    }
}
