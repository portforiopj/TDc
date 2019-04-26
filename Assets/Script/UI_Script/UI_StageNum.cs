using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StageNum : MonoBehaviour
{
    //test 용 정보값 들
    int Test_stageNum = 1;  //현재 스테이지 값
    int Test_CurrentWaveNum = 0;    //현재 웨이브 
    int Test_WaveNum = 6;   //현재 스테이지 총 웨이브 수


    public Text UStg_StgNum;
    public Text UStg_WaveNum;


    void Start()
    {
        //test
        SetStageInfo();
        SetWaveInfo();
    }

    
    void Update()
    {
        
    }

    void SetStageInfo() //스테이지 넘버 출력 함수
    {
        UStg_StgNum.text = Test_stageNum.ToString();
    }
    void SetWaveInfo()  //웨이브 넘버 출력 함수 (현재 진행중인 웨이브 / 스테이지 총 웨이브)
    {
        UStg_WaveNum.text = Test_CurrentWaveNum + " / " + Test_WaveNum;
    }
}
