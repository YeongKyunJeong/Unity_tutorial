using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age = 23;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);

        float height = 169.123467f; //float은 값 끝네 f를 붙여 double과 구분, 4byte, 소수점 아래 7자리 까지만 정확

        double pi = 3.14159265359; //소수점 아래 15자리까지 정확

        bool isBoy = true;
        bool isGirl = false;

        char grade = 'A'; //문자 하나

        string movieTitle = "Love Letter"; //문자 여러개

        Debug.Log("나이는 " + age);
        Debug.Log("가진 돈은 " + money);
        Debug.Log("원주율은 " + pi);

        // var myName = "Yeongkyun"; var는 대입된 값의 데이터 타입을 추론하여 자동으로 타입을 결정
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
