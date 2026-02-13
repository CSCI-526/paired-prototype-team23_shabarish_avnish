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
                // Push in the face's right direction
                Vector2 pushDirection = transform.right;
                rb.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
            }
        }
    }
}
