using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Run : IState
{
    public void Action(Animator animator, Rigidbody2D rigidBody)
    {
        animator.SetBool("Jump", false);
    }
}

