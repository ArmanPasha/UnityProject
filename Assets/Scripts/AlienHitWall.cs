using UnityEngine;
using System.Collections;

public class AlienHitWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("started!!!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Alien"){
			if(target.transform.localScale.x == 1)
				target.transform.localScale = new Vector3 (-1, 1, 1);
			else
				target.transform.localScale = new Vector3 (1, 1, 1);
		Debug.Log ("Hitted!!!");
		}
	}
}
