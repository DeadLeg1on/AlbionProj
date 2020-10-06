using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


enum Bullet {ARROW, POIS_ARROW }


public class scrPlayer : MonoBehaviour {
	//Параметры персонажа//
	[SerializeField]
	public float moveSpeed = 0.4f, hp = 100, maxHp = 100, 
				 mana = 100, maxMana = 100, exp = 0, maxExp = 10, 
				 gold = 0, silver = 0;
	/*********************/

    public Joystick joystick; 
	public Slider sliderHealth, sliderMana, sliderExp;
	Animator anim;
	SpriteRenderer sprite;
	public GameObject objArrow;

	void Start () {
		anim = GetComponent<Animator>();
		sprite = GetComponent<SpriteRenderer>();
		anim.SetBool("stand",true);
		//anim.SetBool("walk",false);
	}
	
	void Update () {
		Vector2 moveVector = (transform.right * joystick.Horizontal + transform.up * joystick.Vertical).normalized; //Вектор гг = вектор джойстика
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
		if (joystick.Horizontal < 0) {
			sprite.flipX = true;
		} else if (joystick.Horizontal > 0) {
			sprite.flipX = false;  
		}
		//ПЕРЕНЕСТИ ПОЗЖЕ: ЕСЛИ ПОЛУЧИЛ УРОН ИЛИ ОПЫТ ТО ОБНОВИТЬ ПОЛОСКИ
		sliderHealth.value = hp;
		sliderHealth.maxValue = maxHp;
		sliderMana.value = mana;
		sliderMana.maxValue = maxMana;
		sliderExp.value = exp;
		sliderExp.maxValue = maxExp;
	}	

	public void TakeDamage(float takeDmg) {
		hp -= takeDmg;
	}	
	public void Shot() {
		Instantiate(objArrow, transform.position, transform.rotation);
	}

}

