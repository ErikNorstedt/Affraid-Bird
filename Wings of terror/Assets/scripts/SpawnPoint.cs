using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject Seagull;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Seagull, transform.position, Quaternion.identity);
    }

  
}
