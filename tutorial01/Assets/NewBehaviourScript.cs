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

        float height = 169.123467f; //float�� �� ���� f�� �ٿ� double�� ����, 4byte, �Ҽ��� �Ʒ� 7�ڸ� ������ ��Ȯ

        double pi = 3.14159265359; //�Ҽ��� �Ʒ� 15�ڸ����� ��Ȯ

        bool isBoy = true;
        bool isGirl = false;

        char grade = 'A'; //���� �ϳ�

        string movieTitle = "Love Letter"; //���� ������

        Debug.Log("���̴� " + age);
        Debug.Log("���� ���� " + money);
        Debug.Log("�������� " + pi);

        // var myName = "Yeongkyun"; var�� ���Ե� ���� ������ Ÿ���� �߷��Ͽ� �ڵ����� Ÿ���� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
