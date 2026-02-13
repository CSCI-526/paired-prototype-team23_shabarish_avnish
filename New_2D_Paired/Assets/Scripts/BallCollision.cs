using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        DoorCollider door = collision.gameObject.GetComponent<DoorCollider>();

        if (door != null)
        {
            door.ActivateGreen();
        }
    }
}
