using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;
    bool fired = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fired == false)
        {
            fired = true;
            StartCoroutine(waiter());
        }

    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        fired = false;
    }
}
