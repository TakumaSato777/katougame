using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndfailScene : MonoBehaviour
{
    GameObject scoreText;
    float endscore;

    void Start()
    {
        this.endscore = EndDirector.score;
        this.scoreText = GameObject.Find("Score");
        this.scoreText.GetComponent<Text>().text = "Score:"+ this.endscore.ToString("F1") + "点";
    }

    public void HomeButtonDown()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void TwitchButtonDown()
    {
        Application.OpenURL("https://www.twitch.tv/kato_junichi0817");
    }

}
