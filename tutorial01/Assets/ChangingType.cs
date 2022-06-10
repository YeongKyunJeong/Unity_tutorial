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

        heightDetail = height; // 에러 x
        height = heightDetail; // 에러 o

        height = (int)heightDetail; // 잃어버리는 정보를 감수하고 직접 명시해 형변환
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
