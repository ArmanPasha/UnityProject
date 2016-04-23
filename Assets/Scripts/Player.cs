using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 10f;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var Xvel = 0f;
		var Yvel = 0f;
		animator.SetInteger("isWalking",0);
		animator.SetInteger ("isFlying", 0);
		if (Input.GetKey ("up")) {
			if (rigidbody2D.velocity.y < speed)
				Yvel = speed;
			
			animator.SetInteger ("isFlying", 1);
		}
		if (Input.GetKey ("right")) {
			if (rigidbody2D.velocity.x < speed)
				Xvel = speed;
			transform.localScale = new Vector3 (1, 1, 1);
			if(animator.GetInteger("isFlying") != 1)
				animator.SetInteger("isWalking",1);
		} else if (Input.GetKey ("left")) {
			if (rigidbody2D.velocity.x > -speed)
				Xvel = -speed;
			transform.localScale = new Vector3 (-1, 1, 1);
			if(animator.GetInteger("isFlying") != 1)
				animator.SetInteger("isWalking",1);
		}


		rigidbody2D.AddForce(new Vector2(Xvel,Yvel));
	}
}
