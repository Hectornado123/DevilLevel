using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public float speed;
    public float jumpingSpeed;
    public GameObject groundCheck;

    public Animator animator;

    private float horizontal;

    //Detectar input de movimiento
    public void Move(InputAction.CallbackContext context) { 
     horizontal = context.ReadValue<Vector2>().x;
    }

    //Asignar movimiento al Rigidbody
    private void FixedUpdate()
    {
        AnimationsCheck();
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    //Detectar colision con el suelo
    public void Jump(InputAction.CallbackContext context) {
        bool grounded = groundCheck.GetComponent<GroundCheck>().grounded;
        if (context.performed && grounded)
        {

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingSpeed);
        }
    }

    //Métodos para activar las animaciones.
    public void AnimationsCheck()
    {
        if (rb.linearVelocity.x == 0)
        {
            animator.SetBool("walk", false);
            animator.SetBool("jump", false);
        }
        else
        {
            animator.SetBool("walk", true);
            animator.SetBool("jump", false);
        }

        if (rb.linearVelocity.y != 0)
        {
            animator.SetBool("walk", false);
            animator.SetBool("jump", true);
        }
    }
    public void AnimationsCheckJump()
    {
        animator.SetBool("jump", true);
        animator.SetBool("walk", false);
    }
}
