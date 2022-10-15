using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Apple;
    public GameObject Banana;
    public GameObject Orange;

    int SpawnIterations = 10;
    int SpawnsPerIteration = 5;
    int SpawnWaitTime = 2;
    float SpawnRadius = 1.5F;
    void Start()
    {
        Apple = Resources.Load("Apple") as GameObject;


        StartCoroutine(SpawnerUL());
        StartCoroutine(SpawnerUR());
        StartCoroutine(SpawnerLL());
        StartCoroutine(SpawnerLR());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnerUL()
    {
        for(int i = 0; i < SpawnIterations; i++) {
            yield return new WaitForSeconds(SpawnWaitTime);
            for (int z = 0; z < SpawnsPerIteration; z++)
            {
                float CircleCenterX = -5 + SpawnRadius;
                float CircleCenterY = 5 - SpawnRadius;
                float AngleRadians = (Mathf.PI * Random.Range(0, 360)) / 180;
                float InstanceRadius = Random.Range(0,SpawnRadius);
                float OffsetX = Mathf.Cos(AngleRadians) * InstanceRadius;
                float OffsetY = Mathf.Sin(AngleRadians) * InstanceRadius;
                Instantiate(Apple, new Vector3(CircleCenterX + OffsetX, CircleCenterY + OffsetY, 0), Quaternion.identity);
            }
        }
    }
    IEnumerator SpawnerUR()
    {
        for(int i = 0; i < SpawnIterations; i++) {
            yield return new WaitForSeconds(SpawnWaitTime);
            for (int z = 0; z < SpawnsPerIteration; z++)
            {
                float CircleCenterX = 5 - SpawnRadius;
                float CircleCenterY = 5 - SpawnRadius;
                float AngleRadians = (Mathf.PI * Random.Range(0, 360)) / 180;
                float InstanceRadius = Random.Range(0,SpawnRadius);
                float OffsetX = Mathf.Cos(AngleRadians) * InstanceRadius;
                float OffsetY = Mathf.Sin(AngleRadians) * InstanceRadius;
                Instantiate(Banana, new Vector3(CircleCenterX + OffsetX, CircleCenterY + OffsetY, 0), Quaternion.identity);
            }
        }
    }
    IEnumerator SpawnerLL()
    {
        for(int i = 0; i < SpawnIterations; i++) {
            yield return new WaitForSeconds(SpawnWaitTime);
            for (int z = 0; z < SpawnsPerIteration; z++)
            {
                float CircleCenterX = -5 + SpawnRadius;
                float CircleCenterY = -5 + SpawnRadius;
                float AngleRadians = (Mathf.PI * Random.Range(0, 360)) / 180;
                float InstanceRadius = Random.Range(0,SpawnRadius);
                float OffsetX = Mathf.Cos(AngleRadians) * InstanceRadius;
                float OffsetY = Mathf.Sin(AngleRadians) * InstanceRadius;
                Instantiate(Orange, new Vector3(CircleCenterX + OffsetX, CircleCenterY + OffsetY, 0), Quaternion.identity);
            }
        }
    }
    IEnumerator SpawnerLR()
    {
        for(int i = 0; i < SpawnIterations; i++) {
            yield return new WaitForSeconds(SpawnWaitTime);
            for (int z = 0; z < SpawnsPerIteration; z++)
            {
                float CircleCenterX = 5 - SpawnRadius;
                float CircleCenterY = -5 + SpawnRadius;
                float AngleRadians = (Mathf.PI * Random.Range(0, 360)) / 180;
                float InstanceRadius = Random.Range(0,SpawnRadius);
                float OffsetX = Mathf.Cos(AngleRadians) * InstanceRadius;
                float OffsetY = Mathf.Sin(AngleRadians) * InstanceRadius;
                Instantiate(Apple, new Vector3(CircleCenterX + OffsetX, CircleCenterY + OffsetY, 0), Quaternion.identity);
            }
        }
    }
}
