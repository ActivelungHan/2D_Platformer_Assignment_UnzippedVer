//Source File Name: SpawnObstacles
//Author: Han Seung Kim
//Last Modified by: Han Seung Kim
//Date Last Modified: 25 Oct 2015
//Program Description: This script is implemented in order to control the spawn of obstacles 
//					   that appear on the platforms to challenge players. 
//					   This is very similar to SpawnCoins script. 

using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour {

    public Transform[] obstacleSpawns;
    public GameObject obstacle;
    

	// Use this for initialization
	void Start () {

        Spawn();
	}

    void Spawn()
    {
        for (int i = 0; i < obstacleSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
                Instantiate(obstacle, obstacleSpawns[i].position, Quaternion.identity);
        }
    }
}
