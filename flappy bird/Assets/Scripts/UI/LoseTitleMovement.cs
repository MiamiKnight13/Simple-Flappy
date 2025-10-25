using UnityEngine;

public class LoseTitleMovement : MonoBehaviour 
{
    public float speed = 3f;
    void Update()
    {
        if(transform.position.x > 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(0, transform.position.y);
        }
    }
}
