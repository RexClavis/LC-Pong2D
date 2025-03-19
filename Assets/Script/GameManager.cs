using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public int playerScoreL = 0;
    public int playerScoreR = 0;
    public TMP_Text txtplayerScoreL;
    public TMP_Text txtplayerScoreR;
    public TMP_Text textWin;
    public GameObject winCon;
    public void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtplayerScoreL.text = playerScoreL.ToString();
        txtplayerScoreR.text = playerScoreR.ToString();
    }

    public void AddScore(string wallName)
    {
        if (wallName == "Left")
        {
            playerScoreR = playerScoreR + 10;
            txtplayerScoreR.text = playerScoreR.ToString();
            ScoreCheck();
        }

        else
        {
            playerScoreL = playerScoreL + 10;
            txtplayerScoreL.text = playerScoreL.ToString();
            ScoreCheck();
        }
    }

    public void ScoreCheck()
    {
        if (playerScoreL == 20)
        {
            WinCondition("Player 1 Wins");
        }
        else if (playerScoreR == 20)
        {
            WinCondition("Player 2 Wins");
        }
    }
    private void WinCondition(string winner)
    {
        winCon.SetActive(true);
        textWin.text = winner;
        Time.timeScale = 0;
    }

}
