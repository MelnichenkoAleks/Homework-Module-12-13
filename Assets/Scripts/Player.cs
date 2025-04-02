using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigibody;
    public Rigidbody Rigidbody => _rigibody;
}
