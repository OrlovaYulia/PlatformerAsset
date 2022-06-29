using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPlatformSpawner : MonoBehaviour
{
    private float distance;
    public float spawnDistance, spawnHeight, border;
    public GameObject platform;
    private Transform player;
    private bool isSpawned = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        distance = Vector2.Distance(player.position, transform.position);

        if(distance < spawnDistance && isSpawned == false)
        {
            Instantiate(platform, transform.position + new Vector3(Random.RandomRange(-border, border), spawnHeight, 0), Quaternion.identity);
            isSpawned = true;
        }
    }
}
