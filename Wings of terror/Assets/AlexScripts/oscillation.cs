using UnityEngine;
using System.Collections;

public class oscillation : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minHeight = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb.position.y < minHeight)
        {
            Debug.Log("Yes");
            rb.AddForce(transform.up * 20);
        }
    }

}
