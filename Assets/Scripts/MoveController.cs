using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] Player _player;

    [SerializeField] private float _jumpPower;
    [SerializeField] private float _speed;

    private bool _isGrounded;
    private bool _jumpRequest;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _jumpRequest = true;
        }

        if (Input.GetKey(KeyCode.D))
            _player.Rigidbody.AddForce(Vector3.right * _speed, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            _player.Rigidbody.AddForce(Vector3.left * _speed, ForceMode.Force);

        if (Input.GetKey(KeyCode.W))
            _player.Rigidbody.AddForce(Vector3.forward * _speed, ForceMode.Force);

        if (Input.GetKey(KeyCode.S))
            _player.Rigidbody.AddForce(Vector3.back * _speed, ForceMode.Force);
    }

    private void FixedUpdate()
    {
        if (_jumpRequest)
        {
            _player.Rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _jumpRequest = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("isGrounded"))
            _isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _isGrounded = false;
    }
}
