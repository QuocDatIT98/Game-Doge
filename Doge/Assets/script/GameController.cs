using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject pnlEndGame;
    public Button btnRestart;
    public Sprite btnIdle;
    public Sprite btnHover;
    public Sprite btnClick;
    public Text txtPoint;
    private int gamePoint;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        pnlEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "tuấn khanh đã né dc " + gamePoint.ToString() + " qua.";
    }

    public void ButtonHover()
    {
        btnRestart.GetComponent<Image>().sprite = btnHover;
    }
    public void ButtonIdle()
    {
        btnRestart.GetComponent<Image>().sprite = btnIdle;
    }
    public void ButtonClick()
    {
        btnRestart.GetComponent<Image>().sprite = btnClick;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
    }
}