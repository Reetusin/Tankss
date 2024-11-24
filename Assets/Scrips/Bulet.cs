using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    public GameObject explosionPrefab;

    public float Distance = 2.0f;

    private float speed = 20f;

    void Start()
    {
        Invoke("SelfDestruct", Distance);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var health = collision.gameObject.GetComponent<Health>();
            health.TakeDamage(10);
        }
        SelfDestruct();
    }

    void SelfDestruct()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
