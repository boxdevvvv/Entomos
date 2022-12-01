using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    
    public int indexRoute;
    public Vector3[] rutas;
    public int eleccionRuta;

    public TextMeshProUGUI txteter;
    public int eter;
    public GameObject[] unidades;
    public GameObject[] rutasObject;
    void Update()
    {
        txteter.text =  eter.ToString();
        #region movimiento teclas visualiza rutas
        if (Input.GetKeyDown(KeyCode.S))
        {
            indexRoute++;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            indexRoute--;

        }
        if (indexRoute < 0)
        {
            indexRoute = 0;
        }
        if (indexRoute > 2)
        {
            indexRoute = 2;
        }
        if (indexRoute == 0)
        {
            rutasObject[0].SetActive(true);
            rutasObject[1].SetActive(false);
            rutasObject[2].SetActive(false);
        }
        if (indexRoute == 1)
        {
            rutasObject[0].SetActive(false);
            rutasObject[1].SetActive(true);
            rutasObject[2].SetActive(false);

        }
        if (indexRoute == 2)
        {
            rutasObject[0].SetActive(false);
            rutasObject[1].SetActive(false);
            rutasObject[2].SetActive(true);
        }



        #endregion 

        #region invocar
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (indexRoute == 0 && eter >= 1)
            {
                eleccionRuta = 0;
                Mineros();
                eter -= 1;
            }
            if (indexRoute == 2 && eter >= 1)
            {
                eleccionRuta = 2;
                Mineros();
                eter -= 1;

            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (indexRoute == 0 && eter >= 3)
            {
                eleccionRuta = 0;
                Atacantes();
                eter -= 3;

            }
            if (indexRoute == 1 && eter >= 3)
            {
                eleccionRuta = 1;
                Atacantes();
                eter -= 3;

            }
            if (indexRoute == 2 && eter >= 3)
            {
                eleccionRuta = 2;
                Atacantes();
                eter -= 3;

            }

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (indexRoute == 1 && eter >= 5)
            {
                eleccionRuta = 1;
                Trasladores();
                eter -= 5;

            }


        }
        #endregion
    }
    public void Mineros()
    {
        Instantiate(unidades[0], transform.position, Quaternion.Euler(rutas[eleccionRuta]));
    }
    public void Atacantes()
    {
        Instantiate(unidades[1], transform.position, Quaternion.Euler(rutas[eleccionRuta]));
    }
    public void Trasladores()
    {
        Instantiate(unidades[2], transform.position, Quaternion.Euler(rutas[eleccionRuta]));

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue"))
        {
            if (other.GetComponent<minero>().recolecto == true)
            {
                eter++;
                other.GetComponent<minero>().recolecto = false;
            }
        }
        if (other.CompareTag("Red"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("sphere"))
        {
            SceneManager.LoadScene(1);
        }
    }

    IEnumerator Eter()
    {
        while (true)
        {
            eter++;
            yield return new WaitForSeconds(1);
        }
    }


    private void Start()
    {
        StartCoroutine(Eter());
    }
}
