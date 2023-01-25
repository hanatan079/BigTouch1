using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSizeBall : MonoBehaviour
{

    //大きいボール以外の配列格納
    public GameObject[] twoSizeBalls;


    //ランダムなブロックを1つ選ぶ
    GameObject GetTwoSizeBall()
    {
        int i = Random.Range(0, twoSizeBalls.Length);
        if(twoSizeBalls[i])
        {
            return twoSizeBalls[i];
        }
        else
        {
            return null;
        }
    }

    //選ばれたブロックを生成する関数
    public GameObject SpawnTwoSizeBall()
    {
        GameObject twoSizeBall = Instantiate(GetTwoSizeBall(), transform.position, Quaternion.identity);
        if(twoSizeBall)
        {
            return twoSizeBall;
        } 
        else
        {
            return null;
        }
    }
}
