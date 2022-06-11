using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody playerRigidbody;

    /*
     public을 이용하지 않고 유니티에 슬롯을 만들지 않고 오브젝트에 붙어있는 컴포넌트를 참조하게 할 때
     슬롯 없이 컴포넌트를 변수에 연결하여 다른 개발자가 건드리지 못하게 할 수 있음
    
    Rigidbody playerRigidbody // public을 뗌


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); // Rigidbody 컴포넌트가 붙어있다면 찾아서 리턴해줌
    }
     */



    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody.AddForce(0, 500, 0); // 게임이 시작되면 y방향으로 500만큼의 힘을 준다.
                                            // 플레이어 오브젝트가 하늘로 솟아오를 것
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            playerRigidbody.AddForce(0, 0, speed); // z축

        if (Input.GetKey(KeyCode.A))
            playerRigidbody.AddForce(-speed, 0, 0); // x축

        if (Input.GetKey(KeyCode.S))
            playerRigidbody.AddForce(0, 0, -speed); // z축

        if (Input.GetKey(KeyCode.D))
            playerRigidbody.AddForce(speed, 0, 0); // x축
    }
    */

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y; // 원래 y속도를 보존시켜야 한다.

        // playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed; // 한 방에 각 x,y,z마다 speed를 곱함

        velocity.y = fallSpeed; // 입력에 따라 결정된 속도값의 y는 기존에 보존해둔 원래의 y로

        playerRigidbody.velocity = velocity;
    
    
    }


}
