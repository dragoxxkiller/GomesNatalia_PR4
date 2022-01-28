using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCTRL : MonoBehaviour
{
 
    Input_Controler inputController;

    Animator animator;

    
    CharacterController cc;

    float speed;
    Vector3 dir;

    bool running = false;

    
    Vector2 stickL;
   
    float triggerR;
    float triggerL;

    
    bool aiming = false;


   
    bool Correr = false;
    bool Straffing = false;


    private void Awake()
    {
        inputController = new Input_Controler();

        
        inputController.Moverse.Run.performed += ctx => { running = true; };
        inputController.Moverse.Run.canceled += ctx => { running = false; };

        inputController.Moverse.Aim.performed += ctx => { aiming = true; };
        inputController.Moverse.Aim.canceled += ctx => { aiming = false; };

        
        inputController.Moverse.Walk.performed += ctx => stickL = ctx.ReadValue<Vector2>();
        inputController.Moverse.Walk.canceled += _ => stickL = Vector2.zero;

        
        inputController.Moverse.StraffeL.performed += ctx => triggerL = ctx.ReadValue<float>();
        inputController.Moverse.StraffeL.canceled += ctx => triggerL = 0f;

        inputController.Moverse.StraffeR.performed += ctx => triggerR = ctx.ReadValue<float>();
        inputController.Moverse.StraffeR.canceled += ctx => triggerR = 0f;

    }


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        DetectarEstado();

        if (running && stickL.y > 0)
        {
            
                animator.SetBool("Correr", true);
            speed = 5f;
            dir = transform.TransformDirection(Vector3.forward);

            cc.SimpleMove(dir * speed * stickL.y);
        }
        else if (Straffing)
        {
            float strafe = triggerR - triggerL;

            animator.SetBool("Correr", false);

            if (strafe != 0)
            {
                animator.SetBool("Straffing", true);
                animator.SetFloat("Straffe", strafe);
            }
            else
            {
                animator.SetBool("Straffing", false);
            }
            dir = transform.TransformDirection(Vector3.right);
            speed = 1.2f;

            cc.SimpleMove(dir * strafe * speed);
        }
        else
        {


            animator.SetBool("Correr", false);
            animator.SetBool("Straffing", false);

            animator.SetFloat("Andar", stickL.y);

            speed = 2.2f;
            dir = transform.TransformDirection(Vector3.forward);

            cc.SimpleMove(dir * speed * stickL.y);
        }









        animator.SetBool("Aim", aiming);

        



        //Giro
        transform.Rotate(new Vector3(0f, stickL.x * 0.8f, 0f));

    }

    void DetectarEstado()
    {
        if(triggerL != 0 || triggerR != 0)
        {
            Straffing = true;
        }
        else
        {
            Straffing = false;
        }
    }

    private void OnEnable()
    {
        inputController.Enable();
    }

    private void OnDisable()
    {
        inputController.Disable();
    }
}
