using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject generator;
    int count = 0;
    float time = 60.0f;
    ItemGenerator script;

    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.generator = GameObject.Find("ItemGenerator");
        script = generator.GetComponent<ItemGenerator>();
    }

    void Update()
    {
        float span = script.span;
        float speed = script.speed;
        Debug.Log(speed);
        this.time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
            SceneManager.LoadScene("ClearScene");
        }
        else if(count == 4 && this.time < 10)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.15f, speed - 0.5f);
            count = 5;
        }
        else if (count == 3 && this.time < 20)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.15f, speed - 0.5f);
            count = 4;
        }
        else if (count == 2 && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(span-0.1f, speed - 0.5f);
            count = 3;
        }
        else if (count == 1 && this.time < 40)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.1f, speed - 0.5f);
            count = 2;
        }
        else if (count == 0 && this.time < 50)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.1f, speed - 0.5f);
            count = 1;
        }

        this.timerText.GetComponent<Text>().text = "残り" + this.time.ToString("F1") + "秒";
    }
}
