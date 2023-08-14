using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetumeiDirector : MonoBehaviour
{
    public void HomeButtonDown()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
