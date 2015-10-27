//Source File Name: SpawnManager
//Author: Han Seung Kim
//Last Modified by: Han Seung Kim
//Date Last Modified: 25 Oct 2015
//Program Description: This script is used for spawning consecutive platforms in random positions horizontally and vertically
//				       in order to challenge players as they proceed in the game to reach the house(the end point).

using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public int maxPlatforms = 20;
    public GameObject platform;
    public float horizontalMin = 6.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6f;

    private Vector2 originPosition;

	// Use this for initialization
	void Start () {

        originPosition = transform.position;
        Spawn();
	
	}
	
	
	void Spawn () 
    {

        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition +
                new Vector2
                    (Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;

        }
	
	}
}
