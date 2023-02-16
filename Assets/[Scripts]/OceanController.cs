using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float verticalSpeed;
    public Boundary boundary;

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
        transform.position = new Vector2(0.0f, boundary.top);
    }
}
