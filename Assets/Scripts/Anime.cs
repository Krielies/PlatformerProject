using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime : MonoBehaviour
{
    private bool canJump = true;
    private Animator Anim;
    private SpriteRenderer spriteRenderer;
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Anim.SetBool("Grounded", true);
        grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Anim.SetBool("Grounded", false);

    }
    // Update is called once per frame
    void Update()
    {
        int MovementInt = Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        if (grounded == false)
        {
            Anim.SetBool("Grounded", false);

        }
        Anim.SetInteger("AnimState", MovementInt);
        if (Input.GetKey(KeyCode.Space))
        {
            Anim.SetTrigger("Jump");
        }
        
    }
}
