using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    public float failDelay = 1f;
    public GameObject winPanel;

    public void EndGame()
    {
        if (isGameOver == false)
        {
            isGameOver = true;
            Invoke("Restart", failDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoalTouch()
    {
        Debug.Log("YOU WINNED");
        winPanel.SetActive(true);
        isGameOver = true;
    }
}
