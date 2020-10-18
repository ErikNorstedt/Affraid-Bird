using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackgorundScript : MonoBehaviour
{
    public float speed;
    public bool hasRandomSpeed;
    public float RandomSpeedlow;
    public float RandomSpeedHigh;

    public float endX;
    public float startX;
 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endX)
        {
            
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
            if (hasRandomSpeed)
            {
                speed = Random.Range(RandomSpeedlow, RandomSpeedHigh);
            }
            
        }
    }
}
