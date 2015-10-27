//Source File Name: Coin
//Author: Han Seung Kim
//Last Modified by: Han Seung Kim
//Date Last Modified: 25 Oct 2015
//Program Description: This script makes coins gatherable.

using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
