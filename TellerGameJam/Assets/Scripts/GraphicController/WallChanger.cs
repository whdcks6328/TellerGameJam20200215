using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChanger : MonoBehaviour
{
    PlayerManager player;
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isBGWhite)
        {
            material.SetColor("_Color", Color.white);
        }
        else
        {
            material.SetColor("_Color", Color.black);
        }
        
    }
}
