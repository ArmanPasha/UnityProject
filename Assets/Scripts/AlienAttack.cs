using UnityEngine;
using System.Collections;

public class AlienAttack : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			anim.SetBool("AlienBAttack", true);
		}
	}

	void OnTriggerExit2D(Collider2D target){
		if(target.gameObject.tag == "Player")
			Destroy(target);
		anim.SetBool("AlienBAttack", false);
	}
}
