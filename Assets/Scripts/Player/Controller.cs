using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public GameObject joystick;
	public GameObject player;
	public int visible;
	void Start () {
		
	}
	
	void Update () {
		//Move();

		/*if (visible == 0){
            joystick.SetActive(false);
        }
        else joystick.SetActive(true);*/
	}
	/*void Move(){
		if (Input.GetKey(KeyCode.D)){	
			transform.Translate(new Vector2(moveSpeed,0) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)){	
			transform.Translate(new Vector2(-moveSpeed,0) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector2(0,moveSpeed) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)){
			transform.Translate(new Vector2(0,-moveSpeed) * Time.deltaTime);
	}*/

}
