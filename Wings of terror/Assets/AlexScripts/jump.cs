using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour
{

    public float forceApplied = 50;
    public float speed = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision!");
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * forceApplied);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
