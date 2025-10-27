using UnityEngine;

public class ColorSettings : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    Color color;

    private void Start()
    {
        color = spriteRenderer.color;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            spriteRenderer.color = color;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.red;
        }
    }
}
