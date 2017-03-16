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
	
	public void fire(Vector2 direction) {
		var bulletInstance = (GameObject) Instantiate( bulletPrefab, spawnPosition.position, spawnPosition.rotation );
		bulletInstance.GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
		
		Destroy(bulletInstance, timeToLive);
	}
}
