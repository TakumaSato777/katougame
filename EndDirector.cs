using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndDirector : MonoBehaviour
{
    GameObject scoreText;
    GameObject generator;
    public static float score = 0;
    float delta = 0;
    ItemGenerator2 script;

    public void SetScore()
    {
        score += 100;
    }

    void Start()
    {
        score = 0;
        this.scoreText = GameObject.Find("Score");
        this.generator = GameObject.Find("ItemGenerator2");
        script = generator.GetComponent<ItemGenerator2>();
    }

    void Update()
    {
        float span = script.span;
        float speed = script.speed;

        this.delta += Time.deltaTime;
        if (this.delta > 5.0)
        {
            score += 100;
            delta = 0;
            this.generator.GetComponent<ItemGenerator2>().SetParameter2(span - 0.02f, speed);
        }
        this.scoreText.GetComponent<Text>().text = score.ToString("F1") + "点";
    }
}
