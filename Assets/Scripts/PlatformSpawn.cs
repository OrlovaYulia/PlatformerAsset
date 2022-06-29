using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject[] platformObjects;
    public int spawnChance;

    private void Awake()
    {
        spawnChance = Random.Range(0, 15);
    }

    void Start()
    {
        
        if (spawnChance <= platformObjects.Length - 1)
        {
            for (int i = 0; i < platformObjects.Length; i++)
            {
                if (i == spawnChance)
                {
                    platformObjects[i].SetActive(true);
                }
                else
                {
                    platformObjects[i].SetActive(false);
                }
            }
        }
    }
}
