using UnityEngine;
using DG.Tweening;

public class BodyShrink : MonoBehaviour {

	[SerializeField] Transform transformObject;
	[SerializeField] float maxSize;
	[SerializeField] float minSize;
	[SerializeField] float step;
	[SerializeField] bool enable = true;
	[SerializeField] float inflateRate = 0.5f;

	Vector2 currentSize;
	Vector2 modifier;



	void Start () {
		currentSize = transformObject.localScale;		
		modifier = new Vector2(step, step);
	}

	void callback() {
		Debug.Log("callback");
	}

	public void shrink() {
		if(enable && currentSize.x > minSize) {
			transform.DOScale((currentSize.x + step), 0.2f)
				.OnComplete( () => transform.DOScale((currentSize.x - step), 0.05f) );

			currentSize -= modifier;
		}
	}

	public void expand() {
		if(enable && currentSize.x < maxSize) {
			currentSize += modifier;
			transformObject.localScale = currentSize;
		}
	}

	private void inflateAnimation() {
		float sizeToInflate = currentSize.x + inflateRate;
		transform.DOScale(sizeToInflate, 0.5f);
	}
	
}
