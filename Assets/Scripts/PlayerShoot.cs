using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	[SerializeField] float speed = 1f;

	public GameObject bulletPrefab;
	public Transform spawnTransform;
	
	public void fire() {
		var bulletInstance = (GameObject) Instantiate( bulletPrefab, spawnTransform.position, spawnTransform.rotation );

		Debug.Log("bullet instance pos: " + spawnTransform.position);
		bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed);
		// bulletInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, speed), ForceMode2D.Impulse);

		Destroy(bulletInstance, 10.0f);
	}

	void Update()
	{	}
}
