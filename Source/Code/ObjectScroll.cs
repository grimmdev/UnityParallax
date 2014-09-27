using UnityEngine;
using System.Collections;

public class ObjectScroll : MonoBehaviour
{
	public enum ScrollStyle { Left, Right };
	public ScrollStyle scrollStyle = ScrollStyle.Left;
	public float scrollSpeed = 5;
	private float move;
	private Vector3 screenLimit;

	// Use this for initialization
	void Awake ()
	{
		screenLimit = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));
		screenLimit.x += this.transform.localScale.x / 2;
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (scrollStyle) {
			case ScrollStyle.Left:
				move = scrollSpeed * Time.deltaTime;  
				transform.Translate (Vector3.left * move, Space.World);  
				if (transform.position.x < -screenLimit.x) {  
					transform.position = new Vector3 (screenLimit.x, transform.position.y, transform.position.z);  
				}
			break;
			case ScrollStyle.Right:
				move = -scrollSpeed * Time.deltaTime;  
				transform.Translate (Vector3.left * move, Space.World);  
				if (transform.position.x < -screenLimit.x) {  
					transform.position = new Vector3 (screenLimit.x, transform.position.y, transform.position.z);  
				}
			break;
		}
	}
}
