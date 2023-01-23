using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    //ball格納
    [SerializeField]
    private GameObject smallGreen, smallRed, mediumGreen, mediumRed, bigGreen, bigRed;

    //スポーンの生成場所用
    [SerializeField]
    private float minPosX = -8.5f, maxPosX = 8.5f;
    private float minPosY = -4.5f, maxPosY = 4.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
