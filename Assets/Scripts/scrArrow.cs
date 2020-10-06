using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrArrow : MonoBehaviour {

	float speed = 2f;
	float direct;


	SpriteRenderer sprite;
	GameObject objPlayer;

	void Start () {
		Destroy(gameObject, 3);
		sprite = GetComponent<SpriteRenderer>();
		objPlayer =  GameObject.Find("Player");
		sprite.flipX = objPlayer.GetComponent<SpriteRenderer>().flipX;
		
		
	}
	
	void Update () {
		if (sprite.flipX == true){
			transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
		} else {
			transform.Translate(new Vector2(speed * Time.deltaTime, 0));
			}
					
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log("Collision!");
		Destroy(gameObject);
	}
	 
}
