using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]


public class Character : MonoBehaviour
{

    private bool flag = false;
    private Rigidbody2D rigidBody;
    [SerializeField] float jumpPower = 500;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            flag = true;
        }
    }

    private void FixedUpdate()
    {
        if(flag==true)
        {
            flag = false;

            rigidBody.AddForce
                (
                Vector2.up * jumpPower*Time.fixedDeltaTime,
                ForceMode2D.Impulse
                );
        }
    }
}
