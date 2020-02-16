using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorManager : MonoBehaviour
{
    PlayerManager player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isBGWhite)
        {
            if(this.gameObject.tag == "WhiteObject")
            {
                this.GetComponentInChildren<BoxCollider>().enabled = false;
            }
            else
            {
                this.GetComponentInChildren<BoxCollider>().enabled = true;
            }
        }
        else
        {
            if (this.gameObject.tag == "BlackObject")
            {
                this.GetComponentInChildren<BoxCollider>().enabled = false;
            }
            else
            {
                this.GetComponentInChildren<BoxCollider>().enabled = true;
            }
        }
    }
    
}
