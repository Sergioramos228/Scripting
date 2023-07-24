using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameObject block1 = GameObject.Find("Block1");
        Destroy(block1);
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("BlockToDelete");

        foreach (GameObject block in blocks)
        {
            block.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
}
