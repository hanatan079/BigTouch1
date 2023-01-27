using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //生成された大きいボール格納(大)
    BigSizeBall bigSizeBall;

    //生成された大きいボール格納(中小)
    TwoSizeBall twoSizeBall;


    //生成されたボール格納(大)
    GameObject activeBigBall;

    //生成されたボール格納(中小)
    GameObject activeTwoSizeBall;


    //新しいポジション生成格納用
    Vector3 ballPos;


    void Awake()
    {
        //大きいボールのオブジェクトを格納
        bigSizeBall = GameObject.FindObjectOfType<BigSizeBall>();
        if(!activeBigBall)
        {
            activeBigBall = bigSizeBall.SpawnBall();
        }

/*
         //中小オブジェクトを格納
        twoSizeBall = GameObject.FindObjectOfType<TwoSizeBall>();
        if(!activeTwoSizeBall)
        {
            activeTwoSizeBall = twoSizeBall.SpawnTwoSizeBall();
        }

            */

    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}