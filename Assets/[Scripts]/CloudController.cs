using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float verticalSpeed;
    public float horizontalSpeed;
    public Boundary boundary;
    public Boundary speeds;

    void Start()
    {
        ResetObject();
    }

    void FixedUpdate()
    {
        Move();
        CheckBonuds();
    }

    void Move()
    {
        transform.position -= new Vector3(horizontalSpeed, verticalSpeed);
    }

    void CheckBonuds()
    {
        if (transform.position.y <= boundary.bottom)
        {
            ResetObject();
        }
    }

    void ResetObject()
    {
        float randomXposition = Random.Range(boundary.left, boundary.right);
        float randomYposition = Random.Range(boundary.top, 3.0f);
        verticalSpeed = Random.Range(speeds.bottom, speeds.top);
        horizontalSpeed = Random.Range(speeds.left, speeds.right);
        transform.position = new Vector2(randomXposition, randomYposition);
    }
}
