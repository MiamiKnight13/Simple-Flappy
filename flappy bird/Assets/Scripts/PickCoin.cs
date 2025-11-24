using System;
using UnityEngine;

public class PickCoin : MonoBehaviour
{
    public event Action OnPickCoin;


    void MoneyText()
    {
        Debug.Log("money bitch!");
    }

    private void Start()
    {
        OnPickCoin += MoneyText;
        OnPickCoin += DeleteCoin;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            OnPickCoin?.Invoke();
        }
    }

    void DeleteCoin()
    {
        Destroy(gameObject);
    }
}
