using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class traslador : MonoBehaviour
{
    public float speed;
    public bool direction;
    private void Update()
    {
       if(!direction)
        {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (direction)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
    }
    public bool win;
    public Transform sphere;
    private void OnDestroy()
    {
        sphere.parent = null;
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("sphere"))
        {
           direction = false;
            print("salio blue");
            speed = 5;
        }
        if(other.CompareTag("BaseBlue"))
        {
            spawn = true;
        }
        
    }
    public bool spawn;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("sphere"))
        {
           other.transform.SetParent(transform);
            sphere = other.transform;
            direction = true;
            win = true;
            speed = 1;
            GetComponentInChildren<Animator>().SetBool("CargandoOrbe", true);
        }
    //    if(spawn && other.CompareTag("BaseBlue"))
      //  {
        //    Destroy(gameObject);
        //}
    }
}
