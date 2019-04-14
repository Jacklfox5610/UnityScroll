using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    float scrollSpeed = -0.03f;
    float endPos = -16f;
    float startPos = 15.8f;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(scrollSpeed, 0, 0);
        if (transform.position.x < endPos)
        {

            this.transform.position = new Vector3(startPos, 0, 0);
        }
    }
}
