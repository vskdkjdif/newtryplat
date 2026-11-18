using UnityEngine;

public class BlockBreaker : MonoBehaviour
{
    [SerializeField] GameObject BlockBreakerParticleEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.GetComponent<Rigidbody2D>().linearVelocityY > -0.1f)
            {
                Instantiate(BlockBreakerParticleEffect, transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
                collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;
                Destroy(gameObject);
            }
        }
    }
}
