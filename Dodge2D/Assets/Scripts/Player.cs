using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    [SerializeField] Vector2 direction;
    [SerializeField] float speed = 1.0f;


    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if(direction.x < 0)
        {
            animator.SetBool("Run", true);
            spriteRenderer.flipX = false;
        }
        else if (direction.x > 0)
        {
            animator.SetBool("Run", true);
            spriteRenderer.flipX = true;   
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
