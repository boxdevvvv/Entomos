using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasladorRed : MonoBehaviour
{
    void Update()
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

    public bool direction;
    public bool win;
    public float speed;
    public Transform sphere;
    private void OnDestroy()
    {
        GameObject.FindGameObjectWithTag("BaseRed").GetComponent<ControladorRed>().spawneo = false;

        sphere.parent = null;
    }
    private void Start()
    {
        speedSecret = speed;
    }
    private float speedSecret;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("sphere"))
        {
            speed = 0;

            direction = false;
            win = false;
            Invoke("StartRun", 3);
            print("se activo  quedarse quieto para correr de blue");
        }
        if (other.CompareTag("BaseRed"))
        {

        }

    }

    public void StartRun()
    {
        speed = speedSecret;
        spawn = false;

        GetComponentInChildren<Animator>().SetBool("TomaOrbe", false);

    }
    public void Idle()
    {
        direction = true;
        win = true;
        speed = 1;
        print("se pego la esfera y retrocede traslador red");
        sphere.transform.parent = null;
        sphere.transform.SetParent(transform);
        GetComponentInChildren<Animator>().SetBool("TomaOrbe", true);

    }
    public bool spawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sphere"))
        {
            if (!spawn)
            {
                spawn = true;
                sphere = other.transform;
                Invoke("Idle", 0.5f);
            }

           
        }
        if (win && other.CompareTag("BaseBlue"))
        {
            //win
        }


























































































    }

}