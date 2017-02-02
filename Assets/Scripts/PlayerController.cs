using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] float speed = 10;
	
	private Rigidbody2D rigidBody;

	PlayerShoot playerShoot;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();			
		playerShoot = GetComponent<PlayerShoot>();
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

		rigidBody.velocity = new Vector2(Mathf.Lerp(0, horizontalMov * speed, 0.8f),
										 Mathf.Lerp(0, verticalMov * speed, 0.8f) );
	}

	void Update() {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			Debug.Log("<color=blue>Fire!</color>");
			playerShoot.fire();
		}		
	}
}
