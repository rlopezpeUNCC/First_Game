
using UnityEngine;

public class check : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()    {
        gameManager.checkPointReached();
    }
}
