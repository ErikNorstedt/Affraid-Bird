using UnityEngine;
using System.Collections;

public class ConstantVelocity : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}