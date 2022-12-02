using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnAround : MonoBehaviour
{
    public GameObject enemy;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy.GetComponent<enemy_script>().changeDirections();
    }
}
