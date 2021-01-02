using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public TimeManager timeManager;
    
    public void CompleteLevel()
    {
        Debug.Log("LEVEL COMPLETED");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("PLAYER DIED");
            timeManager.DoSlowmotion();
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
