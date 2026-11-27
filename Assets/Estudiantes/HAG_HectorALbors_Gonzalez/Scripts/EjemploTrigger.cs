using UnityEngine;
using UnityEngine.SceneManagement;

public class EjemploTrigger : MonoBehaviour
{

    public string nivel = "HAG_Etapa02";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { 
        Debug.Log("AAAAAAAAAAAAAAAAAAAA");
            SceneManager.LoadScene(nivel);
        }
    }
}
