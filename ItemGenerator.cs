using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject kinnikuPrefab;//Prefabの設定
    public GameObject hanaPrefab;
    public GameObject kusyamiPrefab;
    public GameObject makaoPrefab;
    public GameObject hanasoraPrefab;
    public GameObject kingdomPrefab;
    public GameObject ikiikiPrefab;
    GameObject item;

    public float span = 1.0f;//オブジェクトが落ちる間隔
    float delta = 0;//間隔の計測
    public float speed = -0.01f;//落下スピード

    public AudioClip kusyami1;//SE用変数
    public AudioClip hana1;
    public AudioClip hanasora1;
    public AudioClip ikiiki1;
    public AudioClip kinniku1;
    public AudioClip makao1;
    public AudioClip kingdom1;
    AudioSource sound;

    public void SetParameter(float span1, float speed1)
    {
        if(span1 < 0.3f)
        {
            span1 = 0.3f;
        }
        this.span = span1;
        this.speed = speed1;
    }

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)//spanまで達したら
        {
            this.delta = 0;

            int dice = Random.Range(1, 13);//落下オブジェクトの決定
            if(dice <= 3)
            {
                item = Instantiate(hanaPrefab);
                sound.PlayOneShot(hana1);
            }
            else if(dice <= 4)
            {
                item = Instantiate(kusyamiPrefab);
                sound.PlayOneShot(kusyami1);//くしゃみ始まり音
            }
            else if (dice <= 6)
            {
                item = Instantiate(makaoPrefab);
                sound.PlayOneShot(makao1);
            }
            else if (dice <= 8)
            {
                item = Instantiate(kinnikuPrefab);
                sound.PlayOneShot(kinniku1);
            }
            else if (dice <= 9)
            {
                item = Instantiate(hanasoraPrefab);
                sound.PlayOneShot(hanasora1);
            }
            else if (dice <= 10)
            {
                item = Instantiate(kingdomPrefab);
                sound.PlayOneShot(kingdom1);
            }
            else if (dice <= 12)
            {
                item = Instantiate(ikiikiPrefab);
                sound.PlayOneShot(ikiiki1);
            }

            int x = Random.Range(-2, 3)*3;//落下位置の決定
            item.transform.position = new Vector3(x, 6, 0);
            item.GetComponent<ItemController>().dropSpeed = this.speed;
        }
    }
}
