using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	[SerializeField] float speed = 1f;
	public GameObject bulletPrefab;
	public Transform spawnTransform;
	private GameObject blt;
	
	
	public void fire() {
		Debug.Log("<color=pink>INSIDE fire()</color>");
		Debug.Log(spawnTransform.position);
		var bulletInstance = (GameObject) Instantiate( bulletPrefab, spawnTransform.position, spawnTransform.rotation );
		blt = bulletInstance;
		bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed);

		// Destroy(bulletInstance, 2.0f);
	}

	void Update()
	{
		Debug.Log(blt.GetComponent<Rigidbody2D>().velocity);
	}
}
