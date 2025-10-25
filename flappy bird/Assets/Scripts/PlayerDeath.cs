using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject DeathAS;
    public GameObject loseTitle;
    public ScoreText ScoreText;
    public SaveSys SaveSys;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            DeathAS.SetActive(true); 
            Debug.Log("Unfortunately, you lose");
            Destroy(gameObject);

            if(ScoreText.score >= SaveSys.maxScore)
            {
                SaveSys.maxScore = ScoreText.score;
                SaveSys.SaveData(SaveSys.maxScore);
            }

            if (loseTitle != null)
            {
                loseTitle.SetActive(true);
            }
        }
    }

    private void Start()
    {
        loseTitle.SetActive(false);
    }
}
