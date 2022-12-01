using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineroRed : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public bool directionTop;
    public bool directionBot;
    public bool recolecto;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MinasRedTop"))
        {
            transform.rotation = Quaternion.Euler(0, -400, 0);
            // direction = true;
            directionTop = true;
            recolecto = true;
            GetComponentInChildren<Animator>().SetBool("LlevaMineral", true);
        }
        if (other.CompareTag("BaseRed") && directionTop)
        {
            //direction = false;
            transform.rotation = Quaternion.Euler(0, -220, 0);
            GetComponentInChildren<Animator>().SetBool("LlevaMineral", false);


        }
        if (other.CompareTag("BaseRed") && directionBot)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
            GetComponentInChildren<Animator>().SetBool("LlevaMineral", false);

        }
        if (other.CompareTag("MinasRedBot"))
        {
            transform.rotation = Quaternion.Euler(0, 225, 0);
            GetComponentInChildren<Animator>().SetBool("LlevaMineral", true);

            directionBot = true;
            recolecto = true;
        }
    }
}
