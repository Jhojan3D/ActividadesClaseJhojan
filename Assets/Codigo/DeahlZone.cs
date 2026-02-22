using UnityEngine;

public class DeahlZone : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("el personaje se muere");
        }
    }
}
