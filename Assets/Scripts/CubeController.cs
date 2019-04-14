using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > deadLine)
        {
            this.transform.Translate(speed, 0, 0);
        }
        else Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            if (collision.contactCount > 1)
            {
                sound.Play();
               // GetComponent<AudioSource>().volume = 1;
                Debug.Log(collision.contactCount);
            }

        }
        if(collision.gameObject.tag == "ground")
        {
            sound.Play();
        }
        else
        {
           // GetComponent<AudioSource>().volume = 0;
        }
    }
}
