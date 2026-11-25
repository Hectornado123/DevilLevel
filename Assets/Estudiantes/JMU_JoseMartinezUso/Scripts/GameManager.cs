using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("CargarEtapa2", 2);
    }

    void CargarEtapa1()
    {
        SceneManager.LoadScene("JMU_Etapa01");
    }


    void CargarEtapa2()
    {
        SceneManager.LoadScene("JMU_Etapa02");
    }


}
