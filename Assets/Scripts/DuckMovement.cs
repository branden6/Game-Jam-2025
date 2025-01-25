using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody duckRigidbody;
    public float speed = 0.3f;
    public float horizontalInput, verticalInput;
    private Vector3 inputDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        duckRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        inputDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        
    }
    private void FixedUpdate()
    {
        
        duckRigidbody.linearVelocity = inputDirection * speed; //player movement left and right
    }
}
