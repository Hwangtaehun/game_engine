using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������: ������Ʈ �Լ��� ���� �ڵ尡 ������ �������� ������, ���� �ð� return�ϴ� ���� �ڷ�ƾ ���
public class withoutcorutine : MonoBehaviour
{
    public bool isDelay; //false
    public float delayTime = 5.0f;
    public float accumTime;//��������

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDelay == false)
            {
                isDelay = true;//����
                Debug.Log("HP�� 50 ȸ�� �Ǿ����ϴ�.");
            }
            else
            {
                Debug.Log("���� ������ ����� �� �����ϴ�. ");
            }
        }
        if (isDelay)
        {
            accumTime += Time.deltaTime;
            if (accumTime >= delayTime)
            {
                accumTime = 0.0f;
                isDelay = false;//����
            }
        }
    }
}
