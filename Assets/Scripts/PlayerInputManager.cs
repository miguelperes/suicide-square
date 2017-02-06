using UnityEngine;

public class PlayerInputManager : MonoBehaviour {

	PlayerMovement playerMovement;
	PlayerShoot playerShoot;

	float horizontalMove = 0f;
	float verticalMove   = 0f;


	void Start () {
		playerMovement = GetComponent<PlayerMovement>();
		playerShoot = GetComponent<PlayerShoot>();		
	}

	void Update () {
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

	void FixedUpdate() {
			horizontalMove = Input.GetAxisRaw ("Horizontal");
			verticalMove   = Input.GetAxisRaw ("Vertical");	
			playerMovement.move( horizontalMove, verticalMove );		
	}
}
