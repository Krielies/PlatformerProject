using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class charac : MonoBehaviour
{

    public bullet gun;
    // Start is called before the first frame update
    public float _speed;
    public float __jumpStenk;
    public float canJump = 1f;
    Rigidbody2D _rb2d;
    public KeyCode shoot, right, left, jump;
    public int how_m_collect = 0;
    public float collectedJumps, amountOfJumps;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
          canJump = 1 + amountOfJumps;
        }
  
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("you_died");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("you_died");
        }
        if (collision.name == "EndGoal")
        {
            SceneManager.LoadScene("YouWin");
        }

    }
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(collectedJumps >= 10)
        {
            amountOfJumps += 1;
            collectedJumps -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(jump) && canJump > 0 )
        {
            AudioManagerScript.PlaySound("Jump");
            _rb2d.AddForce(__jumpStenk * Vector3.up, ForceMode2D.Impulse);
            canJump -= 1;

        }
        if (Input.GetKeyDown(left))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKeyDown(right))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(left) && canJump > 0 || Input.GetKey(right) && canJump > 0 )
        {

            AudioManagerScript.PlaySound("Footstep");
        }
        if (how_m_collect > 0)
        {
            print(how_m_collect);
        }        
    }
    void FixedUpdate()
    {
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime*_speed;

    }
}
