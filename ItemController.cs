using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropSpeed = -0.03f;
    public PlayerController script;//PlayerControllerクラスが入る
    int kusyamiClone;

    void Start()
    {
        script = GameObject.Find("Jun").GetComponent<PlayerController>();
        dropSpeed = -0.03f;
    }

    void Update()
    {
        kusyamiClone = script.kusyami;

        if (this.kusyamiClone == 1)
        {
            Destroy(gameObject);
        }

        transform.Translate(0, this.dropSpeed, 0);
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }
}