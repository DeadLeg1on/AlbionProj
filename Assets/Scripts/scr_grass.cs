using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_grass : MonoBehaviour {

	SpriteRenderer spr;
	[SerializeField]
	float timer;
	void Start () {
	 spr = GetComponent<SpriteRenderer>();
	}
	
	void Update () {
		if (timer > 0) {
			timer -= Time.fixedDeltaTime;
		}
		else timer = 0;

		if (spr.flipX == true && timer == 0) {
			spr.flipX = false;
			timer = 0.5f;

		}
		else if (spr.flipX == false && timer == 0){
			spr.flipX = true;
			timer = 0.5f;
		}

	}
}
