using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailDirector : MonoBehaviour
{
    private AudioSource huzake;

    void Start()
    {
        huzake = GetComponent<AudioSource>();
        huzake.PlayOneShot(huzake.clip);
    }

    public void RetryButtonDown()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void TitleButtonDown()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void YtButtonDown()
    {
        Application.OpenURL("https://www.youtube.com/c/junchannel");
    }
}
