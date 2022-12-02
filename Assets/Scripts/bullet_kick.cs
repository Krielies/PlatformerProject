using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_kick : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public KeyCode left, right;
    bool looking = true;
    public GameObject player;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Terrain"))
        {
        Destroy(gameObject);
        }
        if (collision.CompareTag("Enemy"))
        {
            AddCunt();
            Destroy(gameObject);
        }
    }
    void Start()
    {
        player = GameObject.Find("player");
        rb.velocity = transform.right * speed;
        StartCoroutine(waiter());
        
    }
    void Update()
    {
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
    public void AddCunt()
    {
       player.GetComponent<charac>().collectedJumps += 1;
    }

    // Update is called once per frame

}
