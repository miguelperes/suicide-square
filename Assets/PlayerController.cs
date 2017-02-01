using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] float speed = 10;
	private Rigidbody2D rigidBody;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();			
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalMov = Input.GetAxisRaw ("Horizontal");
		float verticalMov   = Input.GetAxisRaw ("Vertical");

//		Vector2 movement = new Vector2 (horizontalMov, verticalMov);
//		rigidBody.AddForce (movement, ForceMode2D.Impulse);
//		if (horizontalMov == 0)
//			rigidBody.velocity = new Vector2 (0, rigidBody.velocity.y);//
//		if (verticalMov == 0)
//			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0);

		rigidBody.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f),
										 Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f) );
 		
	}
}
