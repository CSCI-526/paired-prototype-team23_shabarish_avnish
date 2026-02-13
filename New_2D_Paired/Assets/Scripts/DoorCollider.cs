using UnityEngine;
using System.Collections;



public class DoorCollider : MonoBehaviour
{
    private SpriteRenderer sr;

    public float greenDuration = 10f;

    private Color originalColor;
    private bool isGreen = false;
    private Coroutine greenRoutine;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;
    }

    public void ActivateGreen()
    {
        if (greenRoutine != null)
            StopCoroutine(greenRoutine);

        greenRoutine = StartCoroutine(GreenTimer());
    }

    IEnumerator GreenTimer()
    {
        isGreen = true;
        sr.color = Color.green;

        yield return new WaitForSeconds(greenDuration);

        sr.color = originalColor;
        isGreen = false;
    }

    public bool IsGreen()
    {
        return isGreen;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (isGreen)
            {
        GameManager.Instance.LevelCleared();
            }

        }
    }

}
