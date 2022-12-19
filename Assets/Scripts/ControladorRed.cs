using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class ControladorRed : MonoBehaviour
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
        txteter.text = eter.ToString();
        #region movimiento teclas visualiza rutas
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            indexRoute++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
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
        if (Input.GetKeyDown(KeyCode.Keypad1))
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
        if (Input.GetKeyDown(KeyCode.Keypad2))
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
        if (Input.GetKeyDown(KeyCode.Keypad3))
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


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BaseRed") && other.GetComponent<traslador>().spawn == true)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Eter()
    {
        while (true)
        {
            eter++;
            yield return new WaitForSeconds(3);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Red"))
        {
           if(other.GetComponent<mineroRed>().recolecto == true)
            {
                eter++;
            }
           else
            {

            }
        }
        if (other.CompareTag("Blue"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("sphere"))
        {
            wintext.text = "Los Humanos ganan la batalla";
            win.SetActive(true);
        }
    }
    public TextMeshProUGUI wintext;
    public GameObject win;
    private void Start()
    {
        StartCoroutine(Eter());
    }
}
