using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int score;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        score = 0;
        PlayerPrefs.SetInt("Score", score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementScore()
    {
        score++;
    }

    public void StopScore()
    {
        if(PlayerPrefs.HasKey("Highscore"))
        {
            PlayerPrefs.SetInt("Score", score);
            if(score>PlayerPrefs.GetInt("Highscore"))
            {
                PlayerPrefs.SetInt("Highscore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
