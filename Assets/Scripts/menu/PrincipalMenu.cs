using UnityEngine;
using UnityEngine.SceneManagement;
public class PrincipalMenu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
    }

    public GameObject panel;
    public void Controles()
    {
        panel.SetActive(true);
    }


   public void CerrarPanel()
   {
        panel.SetActive(false);

    }
    public void exit()
   {
        Application.Quit();
   }
}
