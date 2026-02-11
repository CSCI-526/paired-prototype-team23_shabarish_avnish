using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Collider2D col;
    private SpriteRenderer sr;

    void Start()
    {
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    public void OpenDoor()
    {
        col.enabled = false;
        sr.color = Color.green;
    }
}
