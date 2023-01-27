using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSizeBall : MonoBehaviour
{

    //大きいボール以外の配列格納
    public GameObject[] twoSizeBalls;

    //ボールpos格納
    private float ballPosX, ballPosY;
    
    //ボール格納用
    [SerializeField]
    private GameObject twoSizePrefab;

    //生成したボールオブジェクト格納用
    private GameObject newTwoSizeBall;

        //新しいポジション生成格納用
    Vector3 ballPos;

    //生成されたボール格納(中小)
    GameObject activeTwoSizeBall;



    
    void Awake()
    {
        GetTwoSizeBall();
    }



    //配列から取り出す
    GameObject GetTwoSizeBall()
    {
        for(int i = 0; i < twoSizeBalls.Length; i ++)
        {
            //生成場所をランダムで設定
            ballPosX = Random.Range(-8.5f, 8.5f);
            ballPosY = Random.Range(-4.5f, 4.5f);

            newTwoSizeBall = Instantiate(twoSizePrefab,new Vector3(ballPosX, ballPosY, 0), Quaternion.identity);
            //親オブジェクトを変える
            newTwoSizeBall.transform.SetParent(transform);

            if(newTwoSizeBall)
            {
                return newTwoSizeBall;
            } 
            else
            {
                return null;
            }

            }
            break;
    }
}

