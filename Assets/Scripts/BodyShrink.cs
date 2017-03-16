using UnityEngine;

public class BodyShrink : MonoBehaviour {

	[SerializeField] Transform transformObject;
	[SerializeField] float maxSize;
	[SerializeField] float minSize;
	[SerializeField] float step;

	Vector2 currentSize;
	Vector2 modifier;

	void Start () {
		currentSize = transformObject.localScale;		
		modifier = new Vector2(step, step);
	}

	public void shrink() {
		if(currentSize.x > minSize) {
			currentSize -= modifier;
			transformObject.localScale = currentSize;
		}
	}

	public void expand() {
		if(currentSize.x < maxSize) {
			currentSize += modifier;
			transformObject.localScale = currentSize;
		}
	}

	void Update(){
	}
}
