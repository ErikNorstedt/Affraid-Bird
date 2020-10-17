using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour
{

    public float forceApplied = 50;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision!");
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * forceApplied);

        
    }
    
}
