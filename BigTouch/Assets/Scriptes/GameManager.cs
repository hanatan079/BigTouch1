using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //生成された大きいボール格納
    BigSizeBall bigSizeBall;

    //生成されたボール格納
    GameObject activeBall;


    void Awake()
    {
        //オブジェクトを格納
        bigSizeBall = GameObject.FindObjectOfType<BigSizeBall>();
        if(!activeBall)
        {
            activeBall = bigSizeBall.SpawnBall();
        }

        //大きいボールの位置調整
        bigBallSize.transform.position = //ここからここまででランダムな場所へ表示する

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
