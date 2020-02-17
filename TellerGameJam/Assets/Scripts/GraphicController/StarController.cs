using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    PlayerManager player;
    ParticleSystem particle;

    ParticleSystem.MainModule ma;// = ps.main;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        particle = GetComponent<ParticleSystem>();
        ma = particle.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isBGWhite)
        {
            ma.startColor = new Color(0, 0, 0);
        }
        else
        {
            ma.startColor = new Color(255, 255, 255);
        }
    }
}
