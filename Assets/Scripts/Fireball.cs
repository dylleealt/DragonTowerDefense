﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
	
	public Transform Fire;
	public GameObject FireballPrefab; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector2 target = Camera.main.ScreenToWorldPoint (new Vector2 (Input.mousePosition.x, 
				Input.mousePosition.y));
			var fireballIn = Instantiate(FireballPrefab, transform.position, transform.rotation);
			Vector2 fireOrigin = new Vector2 (Fire.position.x,Fire.position.y);
			Vector2 fireDirection = target - fireOrigin;
			fireballIn.GetComponent<Rigidbody2D> ().velocity = fireDirection;
		}
	}
}