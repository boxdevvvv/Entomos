using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasladorRed : MonoBehaviour
{
    public float speed;
    public bool direction;
    private void Update()
    {
        if (!direction)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (direction)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
    }
    public Transform sphere;
    private void OnDestroy()
    {
        sphere.parent = null;
    }
    public bool win;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("sphere"))
        {
            direction = false;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sphere"))
        {
          other.transform.SetParent(transform);
            sphere = other.transform;
            direction = true;
            win = true;
            speed = 1;
            GetComponentInChildren<Animator>().SetBool("TomaOrbe", true);
        }
        if (win && other.CompareTag("BaseBlue"))
        {
            //win
        }
    }
}
