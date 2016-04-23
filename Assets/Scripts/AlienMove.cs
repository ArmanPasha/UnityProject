using UnityEngine;
using System.Collections;

public class AlienMove : MonoBehaviour {
	public float speed = 1.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2 (transform.localScale.x, 0) * speed;
	}
}
