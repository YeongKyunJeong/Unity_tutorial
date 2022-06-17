using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬과 씬을 넘나 드는 작업을 하고싶을 때 사용

public class GameManager : MonoBehaviour
{
    public GameObject winUI;

    public ItemBox[] itemBoxes;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {   //GetKey : 키를 누르는 동안
            //GetKeyUp : 키를 떼는 순간
            //GetKeyDown : 키를 누르는 순간

            // SceneManager.LoadScene("Main");
            // "Main"이라는 이름의 씬을 불러온다.
            
            SceneManager.LoadScene(0);
            // 0번 씬을 불러옴
        
        }



        if (isGameOver == true) // ItemBox 오브젝트의 각각의 'isOveraped'값이 모두 True면
        {
            return; // Update함수를 종료시킨다. 더이상 아래 코드를 매 프레임마다 실행하지 않는다.
                    // Update가 안 되는게 아니라 Update에 들어가도 아래 코드를 실행하지 않게 되는 것
        }

        int count = 0;
        for(int i=0; i<3; i++)
        {
            if (itemBoxes[i].isOveraped == true)
            {
                count++; // for문을 돌려 isOveraped가 true가 됐는지 센다.

            }
        }

        if (count >= 3) // count가 3 이상이면 게임 승리
        {
            Debug.Log("게임 승리!");
            isGameOver = true;
            winUI.SetActive(true); // winUI가 참조하는 오브젝트가 보이게 해줌
            

        }


        
    }
}
