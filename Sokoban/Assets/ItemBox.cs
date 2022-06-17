using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;
    // ItemBox�� ItemBox�� �پ� �ִٸ� true. �ݵ�� public���� �ؾ� ���ӸŴ����� ���� ����


    private Renderer myRenderer; // �� ItemBox�� �پ��ִ� Renderer ������Ʈ�� ������ ����

    public Color touchColor; // �浹�� �ٲ� ���� ������ ����
    private Color originalColor; // ���� ���� ������ ����

    void Start()
    {
        // �� ItemBox�� �پ��ִ� Renderer ������Ʈ�� ã�� �����´�.
        // Private�̶� ����Ƽ���� ������ ������ �ʴ´�.
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color; // �������ڸ��� �������� ����
        touchColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Enter : �浹�ϴ� ����
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
            // myRenderer.material.color = Color.red; // ItemBox�� material(����)�� ���� ���������� �ٲ�
            Debug.Log("���� ����Ʈ�� ����");
        }
    }

    void OnTriggerExit(Collider other) // Exit : �������� ����
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }
/*
    void OnTriggerStay(Collider other) // Stay : �پ��ִ� ����
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    
    }
    
*/    
    

}
