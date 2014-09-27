using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour
{
	public enum ScrollStyle { Left, Right };
	public ScrollStyle scrollStyle = ScrollStyle.Left;
	public float scrollSpeed = 1;
	private float offset;

	// Use this for initialization
	void Awake ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (scrollStyle) {
			case ScrollStyle.Left:
				offset = Time.time * scrollSpeed;
			break;
			case ScrollStyle.Right:
				offset = Time.time * -scrollSpeed;
			break;
		}
		renderer.material.mainTextureOffset = new Vector2 (offset, 0);
	}
}
