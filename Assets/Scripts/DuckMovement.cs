using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody duckRigidbody;
    public float speed = 5.0f;
    private float horizontalInput, verticalInput;
    private Vector3 inputDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        duckRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        wasdMovment();
    }

    private void wasdMovment()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        inputDirection = new Vector3((int)horizontalInput, 0, (int)verticalInput).normalized;

        duckRigidbody.linearVelocity = inputDirection * speed;
    }
}
