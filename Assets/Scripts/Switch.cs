using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	Animator anim;
	public Door door;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D taget){
		anim.SetInteger ("SwitchState", 1);
		door.OpenDoor ();
	}

	void OnTriggerExit2D(Collider2D taget){
		anim.SetInteger ("SwitchState", 0);
		door.CloseDoor ();
	}
}
