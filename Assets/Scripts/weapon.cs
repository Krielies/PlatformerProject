using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firepoint;
    public KeyCode shooty_button;
    public GameObject bulletPrefab;
    bool shoot_allowed = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shooty_button) && shoot_allowed == true)
        {
            shoot();
            shoot_allowed = false;
            StartCoroutine(waiter());
        }
    }
    void shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.3F);
        shoot_allowed = true;
    }
}
