using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_CTRL : MonoBehaviour
{
    //Variables para el FSM
    Vector3 goal; //Hacia donde se dirigir�
    float speed; //Velocidad a la que se mover�

    //Necesito saber en todo momento mi distancia al objetivo
    float distance;

    //Booleana que me permite saber si ha detectado al jugador
    bool detected;

    //Componente Nav Mesh Agent
    UnityEngine.AI.NavMeshAgent agent;

    //Destinos posibles (el empty de la ronda y el jugador)
    [SerializeField] Transform emptyGoal, survivor;

    //Componente Animator
    Animator animator;

    //Sonidos
    [SerializeField] AudioClip groar1;
    //AudioSource audioSource;

    //Variables para detectar al jugador
    float visionRange = 10f; //10 metros de visi�n
    float visionConeAngle = 60f; //60� de angulo de visi�n

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();

        //audioSource.GetComponent<AudioSource>();

        //Iniciamos la corrutina que hace que se mueva aleatoriamiente
        StartCoroutine("Ronda");


    }

    // Update is called once per frame
    void Update()
    {
        //Funci�n que permite detectar al jugador
        Detectar();

        //Si me han detectado, cambio la animaci�n
        if (detected)
        {
            animator.SetBool("Attack", true);
            goal = survivor.position;
            //audioSource.Play();
        }
        else
        {
            goal = emptyGoal.position;
            animator.SetBool("Attack", false);
        }

        distance = Vector3.Distance(transform.position, goal);
        //print(distance);
        //Si la distancia al objetivo es menor 
        if (distance > 1f)
        {
            agent.speed = 2f;
        }
        else
        {
            agent.speed = 0f;
        }
        agent.SetDestination(goal);
    }

    IEnumerator Ronda()
    {

        while (!detected)
        {
            //Obtengo valores aleatorios para un nuevo Vector3
            float RandomX = Random.Range(-5f, 5f);
            float RandomZ = Random.Range(-5f, 5f);
            //Creo un Vector3 relativo a mi posici�n
            Vector3 randomPos = new Vector3(RandomX, 0, RandomZ);
            Vector3 destPos = transform.position + randomPos;

            yield return new WaitForSeconds(5f);

            //Muevo el objetivo a la posici�n aleatoria
            emptyGoal.transform.position = destPos;


        }
    }

    void Detectar()
    {
        //Creamos un Vector3 con la posición del jugador, y otro entre nosotros y él
        Vector3 playerPosition = survivor.position;
        Vector3 vectorToPlayer = playerPosition - transform.position;

        //Distancia hasta el jugador y angulo que forma nuestra vision frontal con el
        //Si es una IA, podemmos con navMeshAgent, podemos usar remainingDistance
        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);
        float angleToPlayer = Vector3.Angle(transform.forward, vectorToPlayer);
        //Si está en mi rango y en mi ángulo de visión
        if (distanceToPlayer <= visionRange && angleToPlayer <= visionConeAngle)
        {
            print("Me han pillado");
            detected = true;
        }
        else
        {

            detected = false;

        }

        //print(distanceToPlayer + " - " + detected);

    }
}
