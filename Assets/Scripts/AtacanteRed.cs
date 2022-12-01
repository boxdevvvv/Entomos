using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacanteRed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue"))
        {
            Destroy(other.gameObject);
            GetComponentInChildren<Animator>().SetTrigger("Atack");
        }

        if (other.CompareTag("MinasRedTop"))
        {
            if (directions == 0)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                directions++;
                return;
            }
            if (directions == 1)
            {
                print("direction 1");
                transform.rotation = Quaternion.Euler(0, 50, 0);
                directions++;
                return;
            }
        }
        if (other.CompareTag("MinasRedBot"))
        {
            if (directions == 0)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                directions++;
                return;
            }
            if (directions == 1)
            {
                print("direction 1");
                transform.rotation = Quaternion.Euler(0, 50, 0);
                directions++;
                return;
            }
        }
        if (other.CompareTag("MinaBlueBot"))
        {
            print("direction 1");
            transform.rotation = Quaternion.Euler(0, 130, 0);
            directions++;
        }
        if (other.CompareTag("MinaBlueTop"))
        {
            print("direction 1");
            transform.rotation = Quaternion.Euler(0, 50, 0);
            directions++;
        }
    }
    public int directions;
    public float speed;
    private void Update()
    {

        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }


}
