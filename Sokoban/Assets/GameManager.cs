using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ���� ���� �ѳ� ��� �۾��� �ϰ���� �� ���

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
        {   //GetKey : Ű�� ������ ����
            //GetKeyUp : Ű�� ���� ����
            //GetKeyDown : Ű�� ������ ����

            // SceneManager.LoadScene("Main");
            // "Main"�̶�� �̸��� ���� �ҷ��´�.
            
            SceneManager.LoadScene(0);
            // 0�� ���� �ҷ���
        
        }



        if (isGameOver == true) // ItemBox ������Ʈ�� ������ 'isOveraped'���� ��� True��
        {
            return; // Update�Լ��� �����Ų��. ���̻� �Ʒ� �ڵ带 �� �����Ӹ��� �������� �ʴ´�.
                    // Update�� �� �Ǵ°� �ƴ϶� Update�� ���� �Ʒ� �ڵ带 �������� �ʰ� �Ǵ� ��
        }

        int count = 0;
        for(int i=0; i<3; i++)
        {
            if (itemBoxes[i].isOveraped == true)
            {
                count++; // for���� ���� isOveraped�� true�� �ƴ��� ����.

            }
        }

        if (count >= 3) // count�� 3 �̻��̸� ���� �¸�
        {
            Debug.Log("���� �¸�!");
            isGameOver = true;
            winUI.SetActive(true); // winUI�� �����ϴ� ������Ʈ�� ���̰� ����
            

        }


        
    }
}
