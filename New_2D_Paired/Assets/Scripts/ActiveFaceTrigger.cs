using UnityEngine;

public class ActiveFaceTrigger : MonoBehaviour
{
    public float pushForce = 8f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 direction = (other.transform.position - transform.position).normalized;
                rb.AddForce(direction * pushForce, ForceMode2D.Impulse);
            }
        }
    }
}
