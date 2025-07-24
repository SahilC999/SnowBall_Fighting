using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 2f;
    public bool fadeOut = false;
    public ParticleSystem destroyEffect;
    public AudioClip destroySound;
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    private float timer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        timer = 0f;

        if (destroySound != null && audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (fadeOut && spriteRenderer != null)
        {
            float alpha = Mathf.Lerp(1f, 0f, timer / lifetime);
            spriteRenderer.color = new Color(1f, 1f, 1f, alpha);
        }

        if (timer >= lifetime)
        {
            HandleDestruction();
        }
    }

    void HandleDestruction()
    {
        if (destroyEffect != null)
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
        }

        if (destroySound != null && audioSource != null)
        {
            audioSource.PlayOneShot(destroySound);
        }

        Debug.Log(gameObject.name + " destroyed after " + lifetime + " seconds.");
        Destroy(gameObject);
    }
}
