using System;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float maxTime = 1.5f;
    [SerializeField] float heightRange = 0.45f;
    [SerializeField] GameObject pipe;
    private float timer;
    void Start()
    {
        SpawnPipe();
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0,UnityEngine.Random.Range(-heightRange,heightRange));
        GameObject pipeSpawn = Instantiate(pipe,spawnPos,Quaternion.identity);
        Destroy(pipeSpawn,10f);
    }

    void Update()
    {
        if(timer > maxTime){
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
