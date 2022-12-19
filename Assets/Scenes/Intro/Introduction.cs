using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Introduction : MonoBehaviour
{
    public GameObject[] paneles;





    private void Start()
    {
        StartCoroutine(Starto());
    }


    private int pagina;
    IEnumerator Starto()
    {
       while(true)
        {

            paneles[pagina].SetActive(true);
            pagina++;


            yield return new WaitForSeconds(6);

            if(pagina == 5)
            {
                SceneManager.LoadScene(2);
            }

        }
            yield break;
    }
}
