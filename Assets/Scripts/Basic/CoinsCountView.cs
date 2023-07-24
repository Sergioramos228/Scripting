using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCountView : MonoBehaviour
{
    private Wallet _wallet;

    private void Awake()
    {
        _wallet = FindObjectOfType<Wallet>();
        GetComponentInChildren<Wallet>();
    }

    private void Init(Wallet wallet)
    {

    }
}
