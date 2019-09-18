using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;
    public GameObject levelCompleteUI;
    bool gamehasEnded = false;

    public void completeLevel(){
        levelCompleteUI.SetActive(true);
    }
    public void endGame(){
        if(gamehasEnded == false){
            gamehasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
