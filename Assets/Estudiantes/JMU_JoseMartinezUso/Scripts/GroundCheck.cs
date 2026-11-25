using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool grounded;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hola");
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

}
