using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _jumpPower;

    private bool _jumpRequest;

    private GroundDetector _groundDetector;

    private void Awake()
    {
        _groundDetector = GetComponent<GroundDetector>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _groundDetector.IsGrounded)
        {
            _jumpRequest = true;
        }
    }

    private void FixedUpdate()
    {
        if (_jumpRequest)
        {
            _rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _jumpRequest = false;
        }
    }
}
