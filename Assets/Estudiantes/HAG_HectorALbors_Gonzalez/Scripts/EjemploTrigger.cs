using UnityEngine;

public class EjemploTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { 
        Debug.Log("AAAAAAAAAAAAAAAAAAAA");
        }
    }
}
