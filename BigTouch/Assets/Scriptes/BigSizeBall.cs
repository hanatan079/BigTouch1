using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSizeBall : MonoBehaviour
{

    //生成するBIGブロックを格納
    public GameObject[] bigBalls;

    //ポシション格納用
    private float ballPosX, ballPosY;

        //生成された大きいボール格納(大)
    BigSizeBall bigSizeBall;

    //生成されたボール格納(大)
    GameObject activeBigBall;



    void Awake()
    {
        //大きいボールのオブジェクトを格納
        bigSizeBall = GameObject.FindObjectOfType<BigSizeBall>();
        if(!activeBigBall)
        {
            activeBigBall = bigSizeBall.SpawnBall();
        }
    }



    //ランダムなブロックを1つ選ぶ 
    GameObject GetBigBall()
    {
        int i = Random.Range(0, bigBalls.Length);
        if(bigBalls[i])
        {
            return bigBalls[i];
        }
        else
        {
            return null;
        }
    }
   

    //選ばれたブロックを生成する関数
    public GameObject SpawnBall()
    {
            //生成場所をランダムで設定
            ballPosX = Random.Range(-8.5f, 8.5f);
            ballPosY = Random.Range(-4.5f, 4.5f);

        GameObject bigBall = Instantiate(GetBigBall(), new Vector3(ballPosX, ballPosY, 0), Quaternion.identity);
        if(bigBall)
        {
            return bigBall;
        } 
        else
        {
            return null;
        }
    }
}
