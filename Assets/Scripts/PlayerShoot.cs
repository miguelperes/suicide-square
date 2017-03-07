using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	[SerializeField] float speed = 1f;
	[SerializeField] float timeToLive = 5f;
	[SerializeField] Transform spawnPosition;

	public GameObject bulletPrefab;

	void Start() {
		if( spawnPosition == null) {
			Debug.LogWarning("<b>Spawn position</b> for player's bullets <b>is not set</b>", spawnPosition);
		}
	}
	
	public void fire(Quaternion direction) {

		Debug.Log("dir: " + direction);
		Debug.Log("<i>" + spawnPosition.position + "</i>");
		
		/* Instantiation */
		// var bulletInstance = (GameObject) Instantiate( bulletPrefab, spawnPosition.position, direction );
		var bulletInstance = (GameObject) Instantiate( bulletPrefab, spawnPosition.position, Quaternion.Euler(0f,0f,90f) );

		// Debug.Log("<i>" + bulletInstance.transform.position + "</i>");

		/*Projectile Speed*/
		// bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed);
		// bulletInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, speed), ForceMode2D.Impulse);

		Destroy(bulletInstance, timeToLive);
	}

	void Update()
	{
		// Debug.Log("<b>" + spawnPosition.position + "</b>");
	}
}
