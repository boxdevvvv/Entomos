using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbe : MonoBehaviour
{
/*
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Red"))
        {
            direction = 2;
            other.GetComponent<TrasladorRed>().direction = true;

        }
        if (other.CompareTag("Blue"))
        {
            direction = 1;
            other.GetComponent<traslador>().direction = true;
        }

        if (other.CompareTag("Red") && other.CompareTag("Blue"))
        {
            direction = 0;
        }
    }
    /* private void OnTriggerEnter(Collider other)
     {
         if(other.GetComponent<traslador>().enabled)
         {

         }
         if(other.GetComponent<TrasladorRed>().enabled)
         {

         }
     }
    public int direction;
    private void Update()
    {
        if(direction == 0)
        {
        }
        if(direction == 1)
        {
            transform.transform.Translate(Vector3.left * 1);

        }
        if (direction == 2)
        {
            transform.transform.Translate(Vector3.right * 1);

        }
    }*/
}
