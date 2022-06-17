using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;
    // ItemBox가 ItemBox와 붙어 있다면 true. 반드시 public으로 해야 게임매니저가 참조 가능


    private Renderer myRenderer; // 이 ItemBox에 붙어있는 Renderer 컴포넌트를 참조할 변수

    public Color touchColor; // 충돌시 바뀔 색을 참조할 변수
    private Color originalColor; // 원래 색을 참조할 변수

    void Start()
    {
        // 이 ItemBox에 붙어있는 Renderer 컴포넌트를 찾아 가져온다.
        // Private이라 유니티에서 슬롯이 열리지 않는다.
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color; // 시작하자마자 원래색을 저장
        touchColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Enter : 충돌하는 순간
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
            // myRenderer.material.color = Color.red; // ItemBox의 material(물감)의 색을 빨간색으로 바꿈
            Debug.Log("엔드 포인트에 도달");
        }
    }

    void OnTriggerExit(Collider other) // Exit : 떨어지는 순간
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }
/*
    void OnTriggerStay(Collider other) // Stay : 붙어있는 동안
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    
    }
    
*/    
    

}
