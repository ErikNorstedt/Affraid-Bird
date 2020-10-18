using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnsegulls : MonoBehaviour
{
    [SerializeField]
    private GameObject[] SeagullPattern;

    private int rand;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaceTime;
    public float minTime = 0.65f;


  
    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            rand = Random.Range(0, SeagullPattern.Length);
            Instantiate(SeagullPattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime)
            {
            startTimeBtwSpawn -= decreaceTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
