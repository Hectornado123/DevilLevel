using UnityEngine;
using UnityEngine.SceneManagement;

public class EjemploTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { 
        Debug.Log("AAAAAAAAAAAAAAAAAAAA");
            SceneManager.LoadScene("HAG_Etapa01");
        }
    }
}
