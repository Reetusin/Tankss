using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject explosionPrefab;
    public Health health;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var health = collision.gameObject.GetComponent<Health>();
            health.TakeDamage(10);

            Destroy(gameObject);
        }
    }
}
