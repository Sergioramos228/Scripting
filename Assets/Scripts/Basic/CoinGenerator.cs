using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] private Coin _template;

    private void Start()
    {
        Coin createCoin = Instantiate(_template, Vector3.zero, Quaternion.identity, transform);

        Debug.Log(createCoin.Amount);
    }
}
