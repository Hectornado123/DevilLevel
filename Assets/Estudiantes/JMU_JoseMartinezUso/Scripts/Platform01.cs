using UnityEngine;

public class Platform01 : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.Play("Platform01");
    }


}
