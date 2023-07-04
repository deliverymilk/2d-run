using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject platform;

    void Start()
    {
        //Instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        // ù��° �Ű����� : �����ϰ� ���� ���� ������Ʈ
        // �ι�° �Ű����� : ���� ������Ʈ�� ��ġ
        // ����° �Ű����� : ���� ������Ʈ�� ȸ��

        Instantiate
            (
               platform,
               transform.position,
               Quaternion.identity
            );
        
    }

    void Update()
    {
        
    }
}
