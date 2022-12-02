using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform theSpawner;
    public GameObject enemy;
    public float direction = 1f;
    public float movementSpeed = 5f;
    public Vector3 rotation = new Vector3(0, 180, 0);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTimer());        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction = direction * -1;
        Debug.Log(rotation.y);
        transform.eulerAngles = rotation;
        rotation.y += 180;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.right * direction * Time.deltaTime * movementSpeed;
    }
    IEnumerator SpawnTimer()
    {
        while (true)
        {
            Instantiate(enemy, theSpawner.position, theSpawner.rotation);
            yield return new WaitForSeconds(3F);
        }
    }
}
