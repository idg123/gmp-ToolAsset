using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashLight : MonoBehaviour
{
    bool PlayerGetLight; //true�� ��� ������on
    Light myLight; //light ������Ʈ�� ��� ����

    void Start()
    {
        PlayerGetLight = false; //�ʱ⿡�� �������� �Һ��� ���� ����
        myLight = this.GetComponent<Light>(); //������Ʈ�� ���� light ������Ʈ�� ������.
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerGetLight = PlayerGetLight ? false : true; //rŰ�� ���� �������� �Һ��� on/off
        }

        if (PlayerGetLight == false)
        {
            myLight.intensity = 0; //������ off
        }


        if (PlayerGetLight == true)
        {
            myLight.intensity = 10; //������ on
        }

    }
}
