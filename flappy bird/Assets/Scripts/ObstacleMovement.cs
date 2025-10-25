using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 3f;
    public float destroyXPosition = -15f;

    public void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}