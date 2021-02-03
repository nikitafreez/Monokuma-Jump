using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public static PlatformGenerator instance;
    public GameObject platformPrefab;
    public float lastPlatformPosition = 0f;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        for (int i = 0; i < 10; i++)
        {
            GeneratePlatform();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void GeneratePlatform()
    {
        Vector3 SpawnPoint = new Vector3();
        SpawnPoint.x = Random.Range(-1.7f, 1.7f);
        SpawnPoint.y += Random.Range(lastPlatformPosition + 2f, lastPlatformPosition + 4f);

        Instantiate(platformPrefab, SpawnPoint, Quaternion.identity);
        lastPlatformPosition = SpawnPoint.y;
        Debug.Log($"Pos is: {lastPlatformPosition}");
    }
}
