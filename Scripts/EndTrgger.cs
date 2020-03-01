using UnityEngine;

public class EndTrgger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
// 6. kodlama