using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript: MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public KeyCode left, right;
    bool looking = true;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            Destroy(gameObject);
            Debug.Log("jimin is gay");
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
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

    // Update is called once per frame

}
