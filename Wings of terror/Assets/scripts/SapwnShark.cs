using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSharks : MonoBehaviour
{
    [SerializeField]
    private GameObject Shark;

    public float minrange;
    public float maxrange;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaceTime;
    public float minTime = 0.65f;


  
    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(Shark, transform.position, Quaternion.identity);
            startTimeBtwSpawn = Random.Range(minrange, maxrange);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime)
            {
            minrange -= decreaceTime;
            maxrange -= decreaceTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
