using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(0);
        }
    }

    public static GameManager _gameManager;
    private void Awake()
    {
        _gameManager = this;
    }
    public void restart()
    {
        SceneManager.LoadScene(2);

    }

    public TextMeshProUGUI onePlayerEter;
    public TextMeshProUGUI twoPlayerEter;


    public Controller player1;
    public ControladorRed player2;


    public bool spawneoPlayer1;
    public bool spawneoPlayer2;
  //  public int
    // Update is called once per frame
    // void Update()
    //{
    // onePlayerEter.text = "";
    //}}
    }