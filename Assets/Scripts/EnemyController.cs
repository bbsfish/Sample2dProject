using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rdbody2D;

    float fall_time = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        fall_time += Time.deltaTime;

        if (fall_time > 4)
        {
            rdbody2D.gravityScale *= -1;
            fall_time = 0;
        }
    }
}
