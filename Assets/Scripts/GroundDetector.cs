using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public bool IsGrounded { get; private set; }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("isGrounded"))
            IsGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        IsGrounded = false;
    }
}
