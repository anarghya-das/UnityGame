using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    string gameOver = "Game Over!";
    public float restartDelay = 2f;
    public GameObject CompleteLevelUI;
    public void GameOver()
    {
        if (!gameEnded)
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        FindObjectOfType<PlayerMovement>().enabled=false;
        CompleteLevelUI.SetActive(true);
    }

}
