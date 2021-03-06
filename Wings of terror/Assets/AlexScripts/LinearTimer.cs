﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearTimer : MonoBehaviour
{
    Image timerbar;
    public float maxTime = 30f;
    public float timeLeft;
    public Rigidbody2D rb;
    public float heightOfActivation;
    public GameObject player;

    public float faster;
    public float slower;


    void Start()
    {
        timerbar = GetComponent<Image>();
        timeLeft = maxTime;

        player.GetComponentInChildren<SpriteRenderer>().enabled = true;
        

    }

    // Update is called once per frame
    void Update()
    {
        

        if (rb.position.y > heightOfActivation)
        {
            

            timeLeft -= Time.deltaTime * faster;
            timerbar.fillAmount = timeLeft / maxTime;
            
            if (timeLeft == 0)
            {
                
                // Disable flight
            } else if (timeLeft > 30)
            {
                timeLeft = 30;
            } 
        }
        else
        {
            timeLeft += Time.deltaTime * slower;
            timerbar.fillAmount = timeLeft / maxTime;
        }
    }
}
