using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    private Animator Anim;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void KillEnemy()
    {
        
        Destroy(gameObject);
    }
    public void Death()
    {
        Debug.Log("EnemyDieAnim");
        Anim.SetBool("isAlive", false);
    }
}
