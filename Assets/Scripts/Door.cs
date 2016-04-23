using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenDoor(){
		anim.SetBool ("DoorIsOpen", true);
		collider2D.enabled = false;
	}

	public void CloseDoor(){
		anim.SetBool ("DoorIsOpen", false);
		collider2D.enabled = true;
	}
}
