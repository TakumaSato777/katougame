using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HanaController : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            SceneManager.LoadScene("FailScene");
        }

    }
}
