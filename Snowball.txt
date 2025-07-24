using UnityEngine;

public class Snowball : MonoBehaviour
{
    public float lifetime = 2f;
    public int damage = 20;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "SnowballP1" && other.CompareTag("Player2"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (gameObject.tag == "SnowballP2" && other.CompareTag("Player1"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
