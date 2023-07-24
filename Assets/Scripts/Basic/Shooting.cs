using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        Debug.DrawRay(transform.position, transform.up * 10, Color.red);

        if (hit)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
