using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //生成された大きいボール格納(大)
    BigSizeBall bigSizeBall;

    //生成された大きいボール格納(中小)
    TwoSizeBall twoSizeBall;


    //生成されたボール格納
    GameObject activeBall;

    //ポシション格納用
    private float ballPosX, ballPosY;

    //新しいポジション生成格納用
    Vector3 ballPos;


    void Awake()
    {
        //大きいボールのオブジェクトを格納
        bigSizeBall = GameObject.FindObjectOfType<BigSizeBall>();
        if(!activeBall)
        {
            activeBall = bigSizeBall.SpawnBall();
        }





        //大きいボールの位置調整
       // bigBallSize.transform.position = //ここからここまででランダムな場所へ表示する

    }

    // Start is called before the first frame update
    void Start()
    {
        BallPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //生成場所をランダムで設定
     void BallPos()
    {
        ballPosX = Random.Range(-8.5f, 8.5f);
        ballPosY = Random.Range(-4.5f, 4.5f);
        ballPos = new Vector3(ballPosX,ballPosY, 0);
    }

}




/*
生成場所
 private float minPosX = -8.5f, maxPosX = 8.5f;
    private float minPosY = -4.5f, maxPosY = 4.5f;



        // 30フレーム毎にシーンにプレハブを生成
        if(Time.frameCount % 30 == 0)
        {
            // プレハブの位置をランダムで設定
            float x = Random.Range(-5.0f, 5.0f);
            float z = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, 10.0f, z);
 
            // プレハブを生成
            Instantiate(PrefabCube, pos, Quaternion.identity);
        }    
*/

