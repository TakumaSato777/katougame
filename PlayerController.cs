using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int key = 0;//位置情報
    public int kusyami = 0;
    int makao = 0;
    float mdelta = 0;
    float kdelta = 0;

    GameObject generator;
    ItemGenerator script;

    public AudioClip kusyami2;//SE用変数
    public AudioClip hana2;
    public AudioClip hanasora2;
    public AudioClip ikiiki2;
    public AudioClip kinniku2;
    public AudioClip makao2;
    public AudioClip kingdom2;
    AudioSource sound;

    void Start()
    {
        //Componentを取得
        sound = GetComponent<AudioSource>();
        this.generator = GameObject.Find("ItemGenerator");
        script = generator.GetComponent<ItemGenerator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        float span = script.span;
        float speed = script.speed;

        if (other.gameObject.tag == "Kinniku")//筋肉と接触
        {
            Debug.Log("Tag=Kinniku");
            sound.PlayOneShot(kinniku2);
            this.generator.GetComponent<ItemGenerator>().SetParameter(span -0.05f , speed);
        }
        if (other.gameObject.tag == "Hana")//ハナちゃんと接触
        {
            Debug.Log("Tag=Hana");
            sound.PlayOneShot(hana2);
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.01f, speed);
        }
        if (other.gameObject.tag == "Kusyami")//くしゃみ純一と接触
        {
            sound.PlayOneShot(kusyami2);//くしゃみ接触音
            Debug.Log("Tag=Kusyami");
            kusyami = 1;
        }
        if (other.gameObject.tag == "Makao")//マカオ純一と接触
        {
            Debug.Log("Tag=Makao");
            sound.PlayOneShot(makao2);
            makao = 1;
        }
        if (other.gameObject.tag == "Kingdom")//キングダムと接触
        {
            Debug.Log("Tag=Kingdom");
            sound.PlayOneShot(kingdom2);
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.05f, speed);
        }
        if (other.gameObject.tag == "Hanasora")//ハナソラと接触
        {
            Debug.Log("Tag=Hanasora");
            sound.PlayOneShot(hanasora2);
            this.generator.GetComponent<ItemGenerator>().SetParameter(span + 0.02f, speed);
        }
        if (other.gameObject.tag == "Ikiiki")//イキイキと接触
        {
            Debug.Log("Tag=Ikiiki");
            sound.PlayOneShot(ikiiki2);
            this.generator.GetComponent<ItemGenerator>().SetParameter(span - 0.05f, speed);
        }

        Destroy(other.gameObject);
    }

    void Update()
    {
        if(kusyami == 1)//くしゃみ状態の時間計測
        {
            this.kdelta += Time.deltaTime;
            if(this.kdelta > 0.5)
            {
                kusyami = 0;
                kdelta = 0;
            }
        }

        if(makao == 1)//マカオ状態の時間計測
        {
            this.mdelta += Time.deltaTime;
            if (this.mdelta > 5)
            {
                makao = 0;
                mdelta = 0;
            }
        }

        if (makao == 0)//マカオ状態でないなら正常移動
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))//左に行けるなら左に移動
            {
                if (key > -2)
                {
                    transform.Translate(-3, 0, 0);
                    key = key - 1;
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))//右に行けるなら右に移動
            {
                if (key < 2)
                {
                    transform.Translate(3, 0, 0);
                    key = key + 1;
                }
            }
        }

        if (makao == 1)//マカオ状態なら混乱移動
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))//左に行けるなら左に移動
            {
                if (key > -2)
                {
                    transform.Translate(-3, 0, 0);
                    key = key - 1;
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))//右に行けるなら右に移動
            {
                if (key < 2)
                {
                    transform.Translate(3, 0, 0);
                    key = key + 1;
                }
            }
        }
    }   
}
