using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public DoorCollider door;   // Drag door here in Inspector

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            door.OpenDoor();
        }
    }
}
