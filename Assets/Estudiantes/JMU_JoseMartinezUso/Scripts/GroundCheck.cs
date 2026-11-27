using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool grounded;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            //Debug.Log("Hola");
            grounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        { 
        grounded = false;
        }
    }

}
