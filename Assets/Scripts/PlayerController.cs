﻿using UnityEngine;

public class PlayerController : MonoBehaviour {

	PlayerShoot playerShoot;

	void Start () {
		playerShoot = GetComponent<PlayerShoot>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void Update() {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			Quaternion currentRotation = gameObject.transform.rotation;
			Quaternion rotation = Quaternion.Euler(0f, 0f, 0f);
			playerShoot.fire(rotation);
			Debug.Log("Player position"+gameObject.transform.position);
		} 
		else if( Input.GetKeyDown(KeyCode.RightArrow) ) {
			Quaternion currentRotation = gameObject.transform.rotation;
			Quaternion rotation = Quaternion.Euler(0f, 0f, gameObject.transform.rotation.z + -90f);
			playerShoot.fire(rotation);
		}
	}

	Quaternion rotateZBy(float angle) {
		return Quaternion.identity;
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(gameObject.transform.position, 0.2f);
	}
}
