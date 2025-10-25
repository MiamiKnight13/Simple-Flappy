using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score = 0;
    Text Text;

    private void Start()
    {
        Text = GetComponent<Text>();
        ScoreInit();
    }

    public void ScoreInit()
    {
        Text.text = score.ToString();
        score++;
    }
}
