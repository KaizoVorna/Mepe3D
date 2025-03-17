using UnityEngine;

public class LevelClear : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.GoalTouch();
    }
}
