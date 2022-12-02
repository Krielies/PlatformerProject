using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public bool fired = false;
    public KeyCode right, left;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void shot()
    {
        if (fired == true)
        {
            fired = false;


        }
    }
}
