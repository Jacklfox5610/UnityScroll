using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject prefab;
    float span = 3.0f;
   // float posX;
    float delta=0;
    // キューブの生成位置：X座標
    private float genPosX = 12;

    // キューブの生成位置オフセット
    private float offsetY = 0.3f;
    // キューブの縦方向の間隔
    private float spaceY = 6.9f;

    // キューブの生成位置オフセット
    private float offsetX = 0.5f;
    // キューブの横方向の間隔
    private float spaceX = 0.4f;

    // キューブの生成個数の上限
    private int maxBlockNum = 4;
    // Start is called before the first frame update
    void Start()
    {
        //prefab = GetComponent<GameObject>().gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta>this.span)
        {
            this.delta = 0;
            // posX = Random.Range(3, 10);
            int t = Random.Range(1, maxBlockNum + 1);
            for (int i = 0; i < t; i++)
            {
                GameObject go=Instantiate(prefab) as GameObject;
                go.transform.position = new Vector2(genPosX, this.offsetY+spaceY*i);


                
            }
        }
        
    }


}
