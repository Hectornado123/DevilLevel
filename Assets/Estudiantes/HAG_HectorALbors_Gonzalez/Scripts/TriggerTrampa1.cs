using UnityEngine;

public class TriggerTrampa1 : MonoBehaviour
{

    public GameObject triangulo;

    public int velocidad;

    public bool activo;

    public void Start()
    {
        activo = false;
    }
    public void Update()
    {
        if( activo != false)
        {

            triangulo.transform.Translate(0, velocidad * Time.deltaTime, 0);
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("oña");

            activo = true;
        }
    }
}
