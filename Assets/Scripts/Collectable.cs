using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	private Sprite[] sprites;
	public string resource_name = "";
	// Use this for initialization
	void Start () {
		if (resource_name != "") {
			sprites = Resources.LoadAll<Sprite> (resource_name);
			GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			Destroy(gameObject);
			target.rigidbody2D.AddForce(new Vector2(0,200));
		}
	}
}
