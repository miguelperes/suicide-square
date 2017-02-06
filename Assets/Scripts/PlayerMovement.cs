using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float speed = 5f;

	Rigidbody2D rigidBody;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D>();		
	}

	public void move(float xDir, float yDir) {
		// Vector2 movement = new Vector2 (horizontalMov, verticalMov);
		// rigidBody.AddForce (movement, ForceMode2D.Impulse);
		// if (horizontalMov == 0)
			// rigidBody.velocity = new Vector2 (0, rigidBody.velocity.y);//
		// if (verticalMov == 0)
			// rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0);

		rigidBody.velocity = new Vector2( Mathf.Lerp(0, xDir * speed, 0.8f),
										  Mathf.Lerp(0, yDir * speed, 0.8f) );

	}
}
