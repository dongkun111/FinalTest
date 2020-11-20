using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject danger;

    public float spawntime;
    float d_spawnTime;
    bool d_isGameover;
    int sCore;

    UIManager uI; 
    // Start is called before the first frame update
    void Start()
    {
        d_spawnTime = 00;
        uI = FindObjectOfType<UIManager>();
        uI.SetScoretext("Score: " + sCore);
    }

    // Update is called once per frame
    void Update()
    {
        if (d_isGameover)
        {
            d_spawnTime = 0;
            uI.ShowGameOverPanel(true);
            return;
        }

        d_spawnTime -= Time.deltaTime;

        if (d_spawnTime <= 0)
        {
            SpawnDanger();
            d_spawnTime = spawntime;
        }
    }

    public void SpawnDanger()
    {
        float randPos = Random.Range(-1.75f, -0.88f);

        Vector2 spawnDanger = new Vector2(6, randPos);

        if (danger)
        {
            Instantiate(danger, spawnDanger, Quaternion.identity);
        }
    }

    public void SetScore(int value)
    {
        sCore = value;
    }

    public int GetScore()
    {
        return sCore;
    }

    public void scoreUp()
    {
        sCore++;
        uI.SetScoretext("Score: " + sCore);
    }

    public bool IsGameover()
    {
        return d_isGameover;
    }

    public void SetGameoverState(bool state)
    {
        d_isGameover = state; 
    }
}
