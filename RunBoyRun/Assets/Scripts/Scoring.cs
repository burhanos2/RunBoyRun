using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scoring : MonoBehaviour
{
    [SerializeField]
    private Text Hscore;
    [SerializeField]
    private Text Score;
    private int score_int;
    private Scene scene;

    // Use this for initialization
    void Start()
    {
        Hscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0);
        scene = SceneManager.GetActiveScene();
        if (scene.name == "RunBoyRun")
        {
            WareHouse.timeS = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "RunBoyRun")
        {
            WareHouse.timeS += Time.deltaTime;
        }

        Mathf.Round(WareHouse.timeS);
        score_int = (int)WareHouse.timeS;

        Score.text = "SCORE: " + score_int;

        if (WareHouse.dead == true && score_int > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score_int);
            Hscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0);
            WareHouse.newscore = true;
        }
    }
}
