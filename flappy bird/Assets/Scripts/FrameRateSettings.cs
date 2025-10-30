using UnityEngine;

public class FrameRateSettings : MonoBehaviour
{
    public void FrameRate(int frameRate)
    {
        Application.targetFrameRate = frameRate;
        Debug.Log("fps: " + frameRate);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            FrameRate(24);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            FrameRate(60);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            FrameRate(165);
        }
    }
}
