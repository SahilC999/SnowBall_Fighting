using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject snowballPrefab;
    public Transform firePoint;
    public float snowballSpeed = 10f;
    public KeyCode attackKey = KeyCode.Space; // Player 1: Space, Player 2: UpArrow
    public string snowballTag;

    void Update()
    {
        if (Input.GetKeyDown(attackKey))
        {
            FireSnowball();
        }
    }

    void FireSnowball()
    {
        GameObject snowball = Instantiate(snowballPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = snowball.GetComponent<Rigidbody2D>();

        float direction = transform.localScale.x > 0 ? 1f : -1f;
        rb.velocity = new Vector2(snowballSpeed * direction, 0f);

        snowball.tag = snowballTag;
        snowball.GetComponent<SpriteRenderer>().flipX = direction < 0;
    }
}
