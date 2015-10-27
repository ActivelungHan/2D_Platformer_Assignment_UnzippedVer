//Source File Name: PlatformFall
//Author: Han Seung Kim
//Last Modified by: Han Seung Kim
//Date Last Modified: 25 Oct 2015
//Program Description: This script is used so the platforms will fall after a particular amount of time when a player(car) lands on them.

using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {

	public float fallDelay = 1f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () 
	{
		rb2d = GetComponent<Rigidbody2D>();
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        rb2d.isKinematic = false;
    }



}
