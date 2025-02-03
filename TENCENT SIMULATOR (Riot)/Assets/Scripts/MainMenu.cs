using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onPlay() {
        SceneManager.LoadScene(1);
    }

    public void onQuit() {
        Application.Quit();
    }
}
