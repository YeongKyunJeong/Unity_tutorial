using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchAndRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int year = 2017;

        // 분기문 switch -> if-else문과 같다
        switch (year) // 기준이 되는 변수
        {
            case 2012: // year = 2012인 경우
                Debug.Log("레미제라블");
                break;
            case 2016: // year = 2016
                Debug.Log("곡성");
                break;
            case 2017: // year = 2017
                Debug.Log("트랜스포머5");
                break;
            default: // 어떤 케이스에도 해당되지 않는다면
                Debug.Log("년도가 해당사항 없음");
                break;
        }


        // 반복문
        for (int i = 0; i < 10; i = i + 2)
        {
            Debug.Log("현재 순번: " + i);
        }
        Debug.Log("루프 끝");

        bool isShot = false;
        int index = 0;
        int luckyNumber = 4;

        while (isShot == false)
        {
            index = index + 1;
            if (index == luckyNumber)
            {
                Debug.Log("총알에 맞았다!");
                isShot = true;
            
            }
            else
            {
                Debug.Log("총알에 맞지 않았다.");
            }
        }

        do // do-while. 처음 한 번은 무조건 실행한다. while문은 조건문에 처음부터 맞지 않으면 아예 실행되지 않음 
        {
            Debug.Log("Do-while");
        } while (isShot = false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
