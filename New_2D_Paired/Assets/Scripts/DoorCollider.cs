
using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    private Collider2D col;
    private SpriteRenderer sr;
    private bool isOpen = false;

    void Start()
    {
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isOpen && collision.gameObject.CompareTag("Ball"))
        {
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        isOpen = true;
        col.enabled = false;      // Disable door collision
        sr.color = Color.green;   // Change color
    }
}

