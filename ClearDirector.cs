using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    public void  RetryButtonDown()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void TitleButtonDown()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void YTButtonDown()
    {
        Application.OpenURL("https://www.youtube.com/c/junchannel");
    }
}
