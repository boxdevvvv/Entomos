using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class minero : MonoBehaviour
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
        if (other.CompareTag("MinaBlueTop"))
        {
            transform.rotation = Quaternion.Euler(0, 400, 0);
            // direction = true;
            directionTop = true;
            recolecto = true;
        }
        if (other.CompareTag("BaseBlue") && directionTop)
        {
            //direction = false;
            transform.rotation = Quaternion.Euler(0, 220, 0);

        }
        if (other.CompareTag("BaseBlue") && directionBot)
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);

        }
        if (other.CompareTag("MinaBlueBot"))
        {
            transform.rotation = Quaternion.Euler(0, -225, 0);

           directionBot = true;
            recolecto = true;
        }
    }
}
