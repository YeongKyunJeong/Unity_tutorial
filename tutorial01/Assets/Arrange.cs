using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] scores = new int[10];

        scores[0] = 90;
        scores[1] = 45;
        scores[2] = 60;
        scores[3] = 70;
        scores[4] = 56;
        scores[5] = 80;
        scores[6] = 90;
        scores[7] = 100;
        scores[8] = 45;
        scores[9] = 14;


        for (int i = 0; i < 10; i++)
        {
            Debug.Log("�л� " + i + "��°�� ���� " + scores[i]);
        }

        scores = new int[20]; // ���� ���ҵ��� ���� ���ư��� ���ο� 20�� ũ���� �� �迭�� �Ҵ��
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
