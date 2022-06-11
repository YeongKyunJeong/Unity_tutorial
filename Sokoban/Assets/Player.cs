using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody playerRigidbody;

    /*
     public�� �̿����� �ʰ� ����Ƽ�� ������ ������ �ʰ� ������Ʈ�� �پ��ִ� ������Ʈ�� �����ϰ� �� ��
     ���� ���� ������Ʈ�� ������ �����Ͽ� �ٸ� �����ڰ� �ǵ帮�� ���ϰ� �� �� ����
    
    Rigidbody playerRigidbody // public�� ��


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); // Rigidbody ������Ʈ�� �پ��ִٸ� ã�Ƽ� ��������
    }
     */



    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody.AddForce(0, 500, 0); // ������ ���۵Ǹ� y�������� 500��ŭ�� ���� �ش�.
                                            // �÷��̾� ������Ʈ�� �ϴ÷� �ھƿ��� ��
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            playerRigidbody.AddForce(0, 0, speed); // z��

        if (Input.GetKey(KeyCode.A))
            playerRigidbody.AddForce(-speed, 0, 0); // x��

        if (Input.GetKey(KeyCode.S))
            playerRigidbody.AddForce(0, 0, -speed); // z��

        if (Input.GetKey(KeyCode.D))
            playerRigidbody.AddForce(speed, 0, 0); // x��
    }
    */

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y; // ���� y�ӵ��� �������Ѿ� �Ѵ�.

        // playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed; // �� �濡 �� x,y,z���� speed�� ����

        velocity.y = fallSpeed; // �Է¿� ���� ������ �ӵ����� y�� ������ �����ص� ������ y��

        playerRigidbody.velocity = velocity;
    
    
    }


}
