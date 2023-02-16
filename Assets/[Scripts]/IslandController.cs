using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour
{
    public float verticalSpeed;
    public Boundary boundary;

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
        transform.position -= new Vector3(0.0f, verticalSpeed);
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
        transform.position = new Vector2(randomXposition, boundary.top);
    }
}
