using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawn_rt;
    public GameObject prefab;
    private float next_TimeToSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= next_TimeToSpawn)
        {
            Instantiate(prefab);
            next_TimeToSpawn = Time.time + spawn_rt;
        }
    }
}
