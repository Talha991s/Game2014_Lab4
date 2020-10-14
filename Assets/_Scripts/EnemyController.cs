using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float direction;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBound();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction *Time.deltaTime, 0.0f, 0.0f);
    }
    private  void _CheckBound()
    {
        if(transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Touching");
    }
}
