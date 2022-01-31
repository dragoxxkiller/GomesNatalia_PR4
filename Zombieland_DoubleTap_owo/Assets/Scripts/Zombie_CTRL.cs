using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_CTRL : MonoBehaviour
{

    Vector3 goal;
    float speed;


    float distance;


    bool detected;


    UnityEngine.AI.NavMeshAgent agent;


    [SerializeField] Transform emptyGoal, survivor;


    Animator animator;


    [SerializeField] AudioClip groar1;



    float visionRange = 10f;
    float visionConeAngle = 60f;

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();

        //audioSource.GetComponent<AudioSource>();


        StartCoroutine("Ronda");


    }

    // Update is called once per frame
    void Update()
    {

        Detectar();


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

            float RandomX = Random.Range(-5f, 5f);
            float RandomZ = Random.Range(-5f, 5f);

            Vector3 randomPos = new Vector3(RandomX, 0, RandomZ);
            Vector3 destPos = transform.position + randomPos;

            yield return new WaitForSeconds(5f);


            emptyGoal.transform.position = destPos;


        }
    }

    void Detectar()
    {

        Vector3 playerPosition = survivor.position;
        Vector3 vectorToPlayer = playerPosition - transform.position;


        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);
        float angleToPlayer = Vector3.Angle(transform.forward, vectorToPlayer);

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
