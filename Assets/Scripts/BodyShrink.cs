using UnityEngine;

public class BodyShrink : MonoBehaviour {

	[SerializeField] Transform transformObject;
	[SerializeField] float maxSize;
	[SerializeField] float minSize;
	[SerializeField] float step;
	[SerializeField] bool enabled = true;

	Vector2 currentSize;
	Vector2 modifier;

	void Start () {
		currentSize = transformObject.localScale;		
		modifier = new Vector2(step, step);
	}

	public void shrink() {
		if(enabled && currentSize.x > minSize) {
			currentSize -= modifier;
			transformObject.localScale = currentSize;
		}
	}

	public void expand() {
		if(enabled && currentSize.x < maxSize) {
			currentSize += modifier;
			transformObject.localScale = currentSize;
		}
	}
}
