using DG.Tweening;
using UnityEngine;
public class atacante : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Red"))
      {
            Destroy(other.gameObject);
            GetComponentInChildren<Animator>().SetTrigger("Atack");
      }

      if(other.CompareTag("MinaBlueTop"))
      {
            if(directions == 0)
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
                directions++;
                return;
            }
            if (directions == 1)
            {
                print("direction 1");
                transform.rotation = Quaternion.Euler(0, -50, 0);
                directions++;
                return;
            }           
        }
        if (other.CompareTag("MinaBlueBot"))
        {
            if (directions == 0)
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
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
            print("direction 1");
            transform.rotation = Quaternion.Euler(0, -130, 0);
            directions++;
        }
        if (other.CompareTag("MinasRedTop"))
        {
            print("direction 1");
            transform.rotation = Quaternion.Euler(0, -50, 0);
            directions++;
        }
    }
    public int directions;
    public float speed;
    private void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }


     
}
