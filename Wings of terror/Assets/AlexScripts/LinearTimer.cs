using System.Collections;
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

  
    void Start()
    {
        timerbar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y > heightOfActivation)
        {
            timeLeft -= Time.deltaTime;
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
            timeLeft += Time.deltaTime;
            timerbar.fillAmount = timeLeft / maxTime;
        }
    }
}
