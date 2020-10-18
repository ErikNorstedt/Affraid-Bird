using UnityEngine;
using System.Collections;

public class RandomLeftSpeed : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;

    void FixedUpdate()
    {
        float speed = Random.Range(minSpeed,maxSpeed);
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}