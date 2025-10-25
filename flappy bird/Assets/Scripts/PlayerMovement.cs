using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _force = 10;
    public Rigidbody2D Rigidbody;

    private void Update()
    {
        if(Input.GetMouseButton(0) == true)
        {
            Rigidbody.linearVelocity = Vector2.up * _force;
        }
    }
}
