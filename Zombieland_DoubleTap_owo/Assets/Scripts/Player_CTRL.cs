using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CTRL : MonoBehaviour
{
   Input_Controler inputController;

    bool correr = false;

    Animator animator;

    Vector2 move;

    private void Awake()
    {
        inputControler = new InputController();
        inputController.Moverse.Run.started += ctx => { correr = true; };


        inputController.Moverse.Walk.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputController.Moverse.Walk.cancelled += ctx => move = Vector2.zero
    }

    // Start is called before the first frame update
    void Start()
    {


        animator = GetComponet<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("Run", running);
        animator.SetFloat("Walk", move.y);


    }
    private void OnEnable()
    {
        inputController.Enable();
    }
    private void OnDisable()
    {
        inputControler.Disable();


    }
}
