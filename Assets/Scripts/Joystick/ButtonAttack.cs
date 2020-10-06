using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAttack :  MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	public GameObject objPlayer, objArrow;
    Animator anim;
	//public bool permAttack = true; //Можно ли атаковать
	public float timerAttack; // Таймер и откат атаки
	public float  cdAttack = 1f;
	//public float frame;

	

	void Start(){ 
		objPlayer = GameObject.Find("Player"); //ПРИМЕЧАНИЕ: Ищет объект который ПРИСУСТВУЕТ на сцене.
		anim = objPlayer.GetComponent<Animator>();
	}

	void Update() {
		if (timerAttack > 0) {

			timerAttack -= Time.fixedDeltaTime;
		}	
		else if (timerAttack <= 0 && !anim.GetBool("walk")) {
			timerAttack = 0;
			anim.SetBool("attack",false);
			anim.SetBool("stand",true);
			
		}
		
	}

  public void OnDrag(PointerEventData eventData)
    {   
		if (timerAttack <= 0) {
			anim.SetBool("attack",true);
			anim.SetBool("walk",false);
			anim.SetBool("stand",false);
			timerAttack = cdAttack;
		}
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }
}

