using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayTheGame : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
