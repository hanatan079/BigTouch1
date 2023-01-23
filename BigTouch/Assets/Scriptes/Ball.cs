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

    //生成したオブジェクト管理用リスト
    [SerializeField]
    private List<GameObject> smallGreenPool,smallRedPool, mediumGreenPool, mediumRedPool, bigGreenPool, bigRedPool;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
