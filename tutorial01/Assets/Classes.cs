using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal // Animal Ŭ����
{
    public string name; // ����Ʈ�� private�ε� public�� �ٿ���� �ܺο��� ���� ����� �� �ִ�.
    public string sound;
    public float weight;

}


public class HelloClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal jack = new Animal(); // Animal ��ü 'jack'�� ���� ����
        jack.name = "JACK"; // name�� public�� �ƴϾ��ٸ� ������ ����.
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

        nate = jack; // jack�� ������ �ִ� ������ nate�� ���� ����
        nate.name = "JIMMY"; // jack�� �̸������� �ٲ�� ����!

        Debug.Log(jack.name);
        Debug.Log(nate.name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
