using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalSentence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isGirl = true;

        if (isGirl != false)
        {
            Debug.Log("���� ���ھ�"); // �̰� ��µ�
        }
        else
        {
            Debug.Log("���� ���ھ�");
        }

        isGirl = false;

        if (isGirl == true)
        {
            Debug.Log("���� ���ھ�");
        }
        else
        {
            Debug.Log("���� ���ھ�"); // �̰� ��µ�
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
