using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ڷ�ƾ�� ����ϸ� ���������� ����, ���� �����ϸ� �ܼ�ȭ�ϱ����ؼ� ���->�������� ����, �񵿱� ���α׷����� �ۼ�����
public class corutine : MonoBehaviour
{
    public bool isDelay;
    public float delayTime = 5.0f;
    public float accumTime;
    private float interface_value = 0.0f;
    private int counter = 0;

    private void Update()
    {
        ++counter;

        if (Input.GetKeyDown(KeyCode.A))
        {
            interface_value = interface_value + 1.0f;
            Debug.Log(interface_value);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDelay == false)
            {
                isDelay = true;
                Debug.Log("HP�� 50 ȸ�� �Ǿ����ϴ�.");
                //StartCoroutine("Drink(interface_value)");
                StartCoroutine(Drink(interface_value));
            }
            else
            {
                Debug.Log("���� ������ ����� �� �����ϴ�. ");

            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            StopCoroutine("Drink");
        }

        //if(counter % 100 == 0) Debug.Log("ī����" + counter); 
    }
    IEnumerator Drink(float test_value)
    {
        Debug.Log("�ڷ�ƾ����");
        //yield return new WaitForSeconds(5.0f);
        //yield return new WaitForEndOfFrame(); //��Ÿ���ǹ� ����
        //yield return new WaitForFixedUpdate(); //�� ������ �Ѿ�� ���� �����ӿ��� ����

        //���� ������ �ٷ� ���� 
        //yield return null;

        //�ٷ� ���� (�ؿ� �ڵ� ���� �ȵ�) 
        //yield break; 

        //Debug.Log("�ڷ�ƾ�� ���� ��" + test_value);
        yield return new WaitUntil(() => test_value > 3); //�߰��� ������ ������ �ȵ�

        Debug.Log("�ڷ�ƾ �� ���� ���" + test_value);
        isDelay = false;
    }
}
