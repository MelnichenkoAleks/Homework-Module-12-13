using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigibody;

    [SerializeField] private float _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            _rigibody.AddForce(Vector3.right * _speed, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            _rigibody.AddForce(Vector3.left * _speed, ForceMode.Force);

        if (Input.GetKey(KeyCode.W))
            _rigibody.AddForce(Vector3.forward * _speed, ForceMode.Force);

        if (Input.GetKey(KeyCode.S))
            _rigibody.AddForce(Vector3.back * _speed, ForceMode.Force);
    }
}
