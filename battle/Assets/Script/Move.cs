using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move : MonoBehaviour
{
    private float enemyspeed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * enemyspeed * Time.deltaTime);
    }
}