using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject platform;
    private WaitForSeconds wait = new WaitForSeconds(5);

    void Start()
    {
        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()
    {
        while(true)
        {
            ObjectPoolManager.instance.GetQueue();

            yield return wait;
        }
    }
}
