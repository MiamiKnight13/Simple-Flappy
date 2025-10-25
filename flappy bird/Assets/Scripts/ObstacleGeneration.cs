using Unity.VisualScripting;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnSpeed = 1f;
    public float minY = -0.3f;
    public float maxY = -6f;

    private void Start()
    {
        InvokeRepeating("SpawnObst", spawnSpeed, spawnSpeed);
    }

    void SpawnObst()
    {
        Vector2 _position = new Vector2(12, Random.Range(minY, maxY));
        GameObject  _newObst = Instantiate(Obstacle, _position, Quaternion.identity);
    }    
       
}
