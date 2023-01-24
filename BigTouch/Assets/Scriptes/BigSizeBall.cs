using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSizeBall : MonoBehaviour
{

    //生成するBIGブロックを格納
    public GameObject[] balls;

    //ランダムなブロックを1つ選ぶ
    GameObject GetBigBall()
    {
        int i = Random.Range(0, balls.Length);
        if(balls[i])
        {
            return balls[i];
        }
        else
        {
            return null;
        }
    }

    //選ばれたブロックを生成する関数
    public GameObject SpawnBall()
    {
        GameObject bigBall = Instantiate(GetBigBall(), transform.position, Quaternion.identity);
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
