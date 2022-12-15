using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    Rigidbody2D rgb2d;
    public float direction = 1f;
    public float movementSpeed = 5f, jumpHeight;
    public EdgeCollider2D beakUsedForTurning, otherBeak;
    public Vector3 rotation = new Vector3(0, 180, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        movementSpeed = Random.Range(3, 10);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            beakUsedForTurning.enabled = false;
            otherBeak.enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            gameObject.GetComponent<AnimatorScript>().Death();

            //Destroy(gameObject);
        }
        if (collision.CompareTag("JumpPad"))
        {
            jumpHeight = Random.Range(80, 200);
            rgb2d.AddForce(100f * Vector3.up, ForceMode2D.Impulse);
        }

    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right* direction *  Time.deltaTime * movementSpeed;

    }
    public void changeDirections()
    {
        direction = direction * -1;

        Debug.Log(rotation.y);
        if(direction == -1)
        {
            rotation.y = 180;
        }else if(direction == 1)
        {
            rotation.y = 0;
        }
        transform.eulerAngles = rotation;

    }
    
}
