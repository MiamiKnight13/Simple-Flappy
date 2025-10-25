using UnityEngine;

public class ScoreSys : MonoBehaviour
{
    public ScoreText ScoreText;
    public AudioSource ScoreAS;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreTrigger")
        { 
            ScoreText.ScoreInit();
            ScoreAS.Play();
        }    
    }

    
}
