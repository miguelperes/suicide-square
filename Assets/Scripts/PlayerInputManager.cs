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
			
		} 
		else if( Input.GetKeyDown(KeyCode.RightArrow) ) {
			playerShoot.fire(new Vector2(1f, 0f));
		}
		else if( Input.GetKeyDown(KeyCode.LeftArrow) ) {
			playerShoot.fire(new Vector2(-1f, 0f));
		}
		else if( Input.GetKeyDown(KeyCode.UpArrow) ) {
			playerShoot.fire(new Vector2(0f, 1f));
		}
		else if( Input.GetKeyDown(KeyCode.DownArrow) ) {
			playerShoot.fire(new Vector2(0f, -1f));
		}
	}

	void FixedUpdate() {
			horizontalMove = Input.GetAxisRaw ("Horizontal");
			verticalMove   = Input.GetAxisRaw ("Vertical");	
			playerMovement.move( horizontalMove, verticalMove );		
	}
}
