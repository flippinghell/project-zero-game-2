using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public GameObject Player;
    
    float TotalTime;
    public float ScoreRate = 1;
    float Score;
    private int Health;
    private PlayerBehaviour playerbehaviour;

    public GameObject GameOverPanel;
    public Text ScoreText;
    public Text GameoverText;
    public Text HealthText;

    // Start is called before the first frame update
    void Start()    
    {
        Score = 0;
        SetCountText();
        GameoverText.text = "";
        playerbehaviour = Player.GetComponent<PlayerBehaviour>();
        Health = playerbehaviour.PlayerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime = Time.deltaTime;
        Score += TotalTime * ScoreRate;
        SetCountText();
        Health = playerbehaviour.PlayerHealth;
    }


    void SetCountText()
    {
        ScoreText.text = "Score: " + Score.ToString();
        Debug.Log(Health);
        HealthText.text = "Health: " + Health.ToString();
        Debug.Log(HealthText.text);
        if (Health <= 0)
        {
            GameoverText.text = "Game Over!";
            ScoreText.text = "Score: ";
        }
    }
}
