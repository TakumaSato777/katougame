using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeDirector : MonoBehaviour
{
    public AudioClip yaruo;
    public AudioClip s10;
    AudioSource sound;

    void Start()
    {
        //Componentを取得
        sound = GetComponent<AudioSource>();
    }

    public void StartButtonDown()
    {
        sound.PlayOneShot(yaruo);
        StartCoroutine(Taiki());
    }

    public void SetumeiButtonDown()
    {
        SceneManager.LoadScene("SetumeiScene");
    }

    public void EndlessButtonDown()
    {
        sound.PlayOneShot(yaruo);
        StartCoroutine(Taiki2());
    }

    IEnumerator Taiki()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameScene");
    }

    IEnumerator Taiki2()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("EndScene");
    }

    public void YtButtonDown()
    {
        sound.PlayOneShot(s10);
        Application.OpenURL("https://www.youtube.com/c/junchannel");
    }
}
