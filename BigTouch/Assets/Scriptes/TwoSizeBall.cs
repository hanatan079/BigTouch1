using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSizeBall : MonoBehaviour
{

    //生成する中小ボールを格納
    public GameObject[] bigBalls;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
{

    //大きいボール以外の配列格納
    [SerializeField]
    private GameObject[] twoSizeBalls;

    //ボールpos格納
    private float ballPosX, ballPosY;
    
    //生成したボールオブジェクト格納用
    private GameObject newTwoSizeBall;

        //新しいポジション生成格納用
    Vector3 ballPos;

    //生成されたボール格納(中小)
    GameObject activeTwoSizeBall;



    
    void Awake()
    {
        //ボールのオブジェクトを格納
        if(!activeTwoSizeBall)
        {
            GetTwoSizeBall();
        }

    }



    //配列から取り出す
    void GetTwoSizeBall()
    {
        
            //生成場所をランダムで設定
            ballPosX = Random.Range(-8.5f, 8.5f);
            ballPosY = Random.Range(-4.5f, 4.5f);

            newTwoSizeBall = Instantiate(twoSizeBalls,new Vector3(ballPosX, ballPosY, 0), Quaternion.identity);
            //親オブジェクトを変える
            newTwoSizeBall.transform.SetParent(transform);
            

    }
}

*/