using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualJoystick : Joystick
{
    
    [Header("Fixed Joystick")]
    Vector2 joystickPosition = Vector2.zero;

    private Camera cam = new Camera();
    private Joystick joystick;
    
    GameObject objPlayer;
    Animator anim;
    //SpriteRenderer sprPlayer;
    
    void Start()
    {       
        objPlayer = GameObject.Find("Player");
        anim = objPlayer.GetComponent<Animator>();
       // var sprPlayer = objPlayer.GetComponent<SpriteRenderer>();

        joystickPosition = RectTransformUtility.WorldToScreenPoint(cam, background.position);
    }

    void Update() {
        
    }    

    public override void OnDrag(PointerEventData eventData)
    {   
        if (!anim.GetBool("attack")) {
            Vector2 direction = eventData.position - joystickPosition;
            inputVector = (direction.magnitude > background.sizeDelta.x / 2f) ? direction.normalized : direction / (background.sizeDelta.x / 2f);
            handle.anchoredPosition = (inputVector * background.sizeDelta.x / 2f) * handleLimit;

            //PLAYER PARAM
            anim.SetBool("walk",true);
            anim.SetBool("stand",false);
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
        anim.SetBool("walk",false);
        anim.SetBool("stand",true);
    }
}