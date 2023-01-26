using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSizeBall : MonoBehaviour
{

    //大きいボール以外の配列格納
    public GameObject[] twoSizeBalls;

    //
    private GameObject twoSizeBallType;

    //
    private int count;

    void Start()
    {
                    for(int count = 0; count < twoSizeBalls.Length; count ++)
            {
                GameObject twoSizeBallType = (GameObject)Resources.Load("Prefab" +count.ToString());
                twoSizeBalls[count] = twoSizeBallType;
            }

    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PutOut();
        }

    }

    
    void PutOut()
    {
        foreach(GameObject item in twoSizeBalls)
        {
            count ++;
            Instantiate(item,new Vector3(0, 0, count),Quaternion.identity);
        }
        count = 0;
    }


/*
    //ブロックを生成する関数
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

    */
    
}
