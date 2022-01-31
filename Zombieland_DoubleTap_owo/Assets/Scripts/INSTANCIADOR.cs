using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSTANCIADOR : MonoBehaviour
{
    [SerializeField] GameObject zombi;

    [SerializeField] GameObject[] instArray;

    // Start is called before the first frame update
    void Start()
    {
        instArray = GameObject.FindGameObjectsWithTag("ZombiPos");

        for (int n = 0; n < instArray.Length; n++)
        {
            Instantiate(zombi, instArray[n].transform.position, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
