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
            Debug.Log("나는 여자야"); // 이게 출력됨
        }
        else
        {
            Debug.Log("나는 남자야");
        }

        isGirl = false;

        if (isGirl == true)
        {
            Debug.Log("나는 여자야");
        }
        else
        {
            Debug.Log("나는 남자야"); // 이게 출력됨
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
