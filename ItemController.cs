using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropSpeed = -5.0f;
    public PlayerController script;//PlayerControllerクラスが入る
    int kusyamiClone;

    void Start()
    {
        script = GameObject.Find("Jun").GetComponent<PlayerController>();
        dropSpeed = -5.0f;
    }

    void Update()
    {
        kusyamiClone = script.kusyami;

        if (this.kusyamiClone == 1)
        {
            Destroy(gameObject);
        }

        // 時間単位で移動速度を調整
        float moveDistance = dropSpeed * Time.deltaTime;
        transform.Translate(0, moveDistance, 0);
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }
}