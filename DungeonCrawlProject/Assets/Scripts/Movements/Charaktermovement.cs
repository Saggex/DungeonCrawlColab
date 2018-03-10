using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Charaktermovement : MonoBehaviour {

    Animator animator;
    Rigidbody2D rb;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void Move(Vector2 direction)
    {
        if (animator)
        {
            animator.SetBool("Walking", true);
        }
        rb.velocity = direction;
    }

    public void Idle()
    {
        if (animator)
        {
            animator.SetBool("Walking", false);
        }

        rb.velocity = new Vector2(0, 0);
    }
}
