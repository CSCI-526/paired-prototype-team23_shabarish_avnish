using UnityEngine;

public class WallHit : MonoBehaviour
{
    private bool hit = false;

    public void MarkHit()
    {
        if (!hit)
        {
            hit = true;
            // GameManager.Instance.RegisterWallHit();
        }
    }
}
