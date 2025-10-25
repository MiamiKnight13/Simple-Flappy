using UnityEngine;
using UnityEngine.UI;

public class MaxScoreText : MonoBehaviour
{
    Text text;
    public SaveSys SaveSys;

    private void Start()
    {
        SaveSys.LoadData();
        text = GetComponent<Text>();
        text.text = "Max Score: " + SaveSys.maxScore.ToString();
    }
}
