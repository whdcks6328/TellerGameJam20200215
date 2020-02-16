using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorManager : MonoBehaviour
{
    PlayerManager player;
    BoxCollider[] boxColliders;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        boxColliders = this.GetComponentsInChildren<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "WhiteObject")
        {
            foreach(var box in boxColliders)
            {
                box.enabled = !player.isBGWhite;
            }
        }
        else
        {
            foreach (var box in boxColliders)
            {
                box.enabled = player.isBGWhite;
            }
        }
    }
}
