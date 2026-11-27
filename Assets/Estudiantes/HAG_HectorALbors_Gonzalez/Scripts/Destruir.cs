using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject suelo;

  

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Destroy(suelo.gameObject);
        }
    }
}
