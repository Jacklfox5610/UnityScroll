using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject unitychan;
    public GameObject bg;
    public  Text runLength;
        public Text gameOver;
    float speed = 0.03f;
    float length;
    bool isGameOver=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            length += speed;
            runLength.text = "距離" + length.ToString("F2")+"m";
        }
        if (isGameOver == true)
        {
            if (Input.GetMouseButton(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }




    }
    public void GameOver()
    {
        gameOver.text = "GameOver";
        isGameOver = true;
    }
}
