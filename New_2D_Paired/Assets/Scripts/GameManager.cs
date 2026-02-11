using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalWalls;
    private int wallsHit = 0;

    public DoorController door;

    void Awake()
    {
        Instance = this;
    }

    public void RegisterWallHit()
    {
        wallsHit++;

        if (wallsHit >= totalWalls)
        {
            door.OpenDoor();
        }
    }
}
