using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    public float Distance = 2.0f;
    private float speed = 20f;

    void Start()
    {
        Destroy(gameObject, Distance);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
