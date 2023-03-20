using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bobControllor : MonoBehaviour
{
    public Rigidbody2D rdbody2D;

    float jumpPower = 370.0f;
    float walkPower = 120.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rdbody2D.AddForce(transform.up * jumpPower);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rdbody2D.AddForce(transform.right * walkPower);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rdbody2D.AddForce(transform.right * -1 * walkPower);
        }
        Vector3 posi = this.transform.position;
        if (posi.y < -5)
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}