using NUnit.Framework.Internal.Builders;
using UnityEngine;

public class SaveSys : MonoBehaviour
{
    public int maxScore = 0;
    public void SaveData(int num)
    {
        PlayerPrefs.SetInt("key", num );
        PlayerPrefs.Save();
        Debug.Log("Data saved: " + num );
    }

    public void LoadData()
    {
        maxScore = PlayerPrefs.GetInt("key", maxScore);
        Debug.Log("Data loaded: " + maxScore);
    }
}