using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlatformGenerator : MonoBehaviour
{
   
    int numberOfPlatforms = 300;
    float width = 7f;
    float minY = 3f;
    float maxY = 4f;
    int pp, sp, mp = 0;
    int ppMax = 160;
    int spMax = 100;
    int dpMax = 40;

public GameObject platform;
public GameObject spring;
public GameObject drop;


    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            int create = Random.Range(0, 3);
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-width, width);
            if (create == 0)
            {
                if (pp == ppMax)
                {
                    Instantiate(spring, spawnPosition, Quaternion.identity);
                    sp++;
                }
                else
                {
                    Instantiate(platform, spawnPosition, Quaternion.identity);
                    pp++;
                }
            }

            else if (create == 1)
            {
                if (sp == spMax)
                {
                    Instantiate(platform, spawnPosition, Quaternion.identity);
                    pp++;
                }
                else
                {
                    Instantiate(spring, spawnPosition, Quaternion.identity);
                    sp++;
                }
            }

            else if (create == 2)
            {
                if (mp == dpMax)
                {
                    Instantiate(platform, spawnPosition, Quaternion.identity);
                    pp++;
                }
                else
                {
                    Instantiate(drop, spawnPosition, Quaternion.identity);
                    mp++;
                }
            }
        }

    }

}
