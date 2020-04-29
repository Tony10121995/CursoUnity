using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer sprite;

    [SerializeField]
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //move left
            animator.SetBool("RunSide", true);
            animator.SetBool("RunDown", false);
            animator.SetBool("RunUp", false);
            sprite.flipX = false;
            transform.position = new Vector2(transform.position.x - moveSpeed,transform.position.y);
           
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //move right
            animator.SetBool("RunSide", true);
            animator.SetBool("RunDown", false);
            animator.SetBool("RunUp", false);
            sprite.flipX = true;
            transform.position = new Vector2(transform.position.x + moveSpeed, transform.position.y);
            
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow))
        {
            //move Down
            animator.SetBool("RunDown", true);
            animator.SetBool("RunSide", false);
            animator.SetBool("RunUp", false);
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);
           
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow))
        {
            //move Up
            animator.SetBool("RunUp", true);
            animator.SetBool("RunSide", false);
            animator.SetBool("RunDown", false);
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed);
            
        }
    }
}
