using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class UIManager : MonoBehaviour
{
    public Text scoreText;

    public GameObject gameOverpanel;

    public void SetScoretext(string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }

    public void ShowGameOverPanel(bool isShow)
    {
        if (gameOverpanel)
        {
            gameOverpanel.SetActive(isShow);
        }
            
    }
}
