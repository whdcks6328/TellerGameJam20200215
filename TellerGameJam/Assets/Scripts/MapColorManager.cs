﻿using System.Collections;
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

        }
        else
        {

        }
    }
    
}
