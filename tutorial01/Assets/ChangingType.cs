using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int height = 170;
        float heightDetail = 170.3f;

        heightDetail = height; // ���� x
        height = heightDetail; // ���� o

        height = (int)heightDetail; // �Ҿ������ ������ �����ϰ� ���� ����� ����ȯ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
