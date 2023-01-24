using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    //ball格納
    [SerializeField]
    private GameObject smallGreen, smallRed, mediumGreen, mediumRed, bigGreen, bigRed;

    //ボールの生成場所用
    [SerializeField]
    private float minPosX = -8.5f, maxPosX = 8.5f;
    private float minPosY = -4.5f, maxPosY = 4.5f;

    //ボールの種類数(大以外)
    private int ballCount = 4;

    //ボールの種類数(大)
    private int bigBallCount = 2;

    //生成するオブジェクト格納用
    private int ballSpawne;

    //ゲームオブジェクト格納
    public GameObject twoSizegetBall;
    public GameObject bigSizeGetBall;

    //生成したオブジェクト管理用リスト
    [SerializeField]
    private List<GameObject> smallGreenPool,smallRedPool, mediumGreenPool, mediumRedPool, bigGreenPool, bigRedPool;


    // Start is called before the first frame update
    void Start()
    {
        //タグでゲームオブジェクトを取得
        twoSizegetBall = GameObject.Find("TwoSizeBall");
        bigSizeGetBall = GameObject.Find("BigSizeBall");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ///表示させる
    void DisplayBall()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //BigBallか判定

        }
    }

    //BigBallか判定
    void OnBigBall()
    {
        if(bigSizeGetBall)
        {
            //大きいのならランダムな場所へボールを再表示
        }
        else if()
        {
            //大きいの以外なら揺れる振動
        }
    }

}
