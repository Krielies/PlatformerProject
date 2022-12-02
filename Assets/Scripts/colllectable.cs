using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colllectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject f = GameObject.Find("player");
            charac bScript = f.GetComponent<charac>();
            bScript.how_m_collect++;
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
