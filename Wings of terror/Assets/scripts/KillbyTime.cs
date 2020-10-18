using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillbyTime : MonoBehaviour
{
    public float deathTimer = 10f;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, deathTimer);
    }
}
