using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class ObstacleGeneration : MonoBehaviour
{
    public GameObject Obstacle;
    public GameObject Coin;

    public float obstSpawnSpeed = 1f;
    public float coinSpawnSpeed = 5f;
    public float minY = -0.3f;
    public float maxY = -6f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObst), obstSpawnSpeed, obstSpawnSpeed);
        InvokeRepeating(nameof(SpawnCoin), coinSpawnSpeed, coinSpawnSpeed);
    }

    void SpawnObst()
    {
        Vector2 _position = new Vector2(12, Random.Range(minY, maxY));
        GameObject  _newObst = Instantiate(Obstacle, _position, Quaternion.identity);
    }

    void SpawnCoin()
    {
        Vector2 _position = new Vector2(6.5f, Random.Range(-4.5f, 4.5f));
        GameObject _newCoin = Instantiate(Coin, _position, Quaternion.identity);
    }
       
}
