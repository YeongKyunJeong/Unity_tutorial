using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchAndRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int year = 2017;

        // �б⹮ switch -> if-else���� ����
        switch (year) // ������ �Ǵ� ����
        {
            case 2012: // year = 2012�� ���
                Debug.Log("���������");
                break;
            case 2016: // year = 2016
                Debug.Log("�");
                break;
            case 2017: // year = 2017
                Debug.Log("Ʈ��������5");
                break;
            default: // � ���̽����� �ش���� �ʴ´ٸ�
                Debug.Log("�⵵�� �ش���� ����");
                break;
        }


        // �ݺ���
        for (int i = 0; i < 10; i = i + 2)
        {
            Debug.Log("���� ����: " + i);
        }
        Debug.Log("���� ��");

        bool isShot = false;
        int index = 0;
        int luckyNumber = 4;

        while (isShot == false)
        {
            index = index + 1;
            if (index == luckyNumber)
            {
                Debug.Log("�Ѿ˿� �¾Ҵ�!");
                isShot = true;
            
            }
            else
            {
                Debug.Log("�Ѿ˿� ���� �ʾҴ�.");
            }
        }

        do // do-while. ó�� �� ���� ������ �����Ѵ�. while���� ���ǹ��� ó������ ���� ������ �ƿ� ������� ���� 
        {
            Debug.Log("Do-while");
        } while (isShot = false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
