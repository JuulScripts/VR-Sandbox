using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPhysics : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;
    [SerializeField] float _rotation = 0f;
    [SerializeField] private InputActionAsset _InputActions;
    //speed lines later 
    private Rigidbody _rb;

    private void Start()
    {
         _rb = GetComponent<Rigidbody>();

    }


    public void Move(Vector2 moveInput)
    {
        Vector3 moveDirection = transform.forward * moveInput.y + transform.right * moveInput.x;
        _rb.AddForce(moveDirection * _speed);
    
    }


    void OnCollisionEnter(Collision collision)
    {
        _rb.useGravity = true; 
    }

}
