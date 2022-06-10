using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal // Animal 클래스
{
    public string name; // 디폴트는 private인데 public을 붙여줘야 외부에서 보고 사용할 수 있다.
    public string sound;
    public float weight;

}


public class HelloClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal jack = new Animal(); // Animal 객체 'jack'을 새로 만듦
        jack.name = "JACK"; // name이 public이 아니었다면 에러가 난다.
        jack.sound = "Bark";
        jack.weight = 4.5f;

        Animal annie = new Animal();
        annie.name = "ANNIE";
        annie.sound = "Wee";
        annie.weight = 0.8f;

        Animal nate = new Animal();
        nate.name = "NATE";
        nate.sound = "NYaa";
        nate.weight = 1.2f;

        nate = jack; // jack이 가지고 있는 정보로 nate를 덮어 씌움
        nate.name = "JIMMY"; // jack의 이름까지도 바뀌니 주의!

        Debug.Log(jack.name);
        Debug.Log(nate.name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
