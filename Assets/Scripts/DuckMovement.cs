using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody duckRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        duckRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            duckRigidbody.AddForce(Vector3.forward);
        }
        if(Input.GetKey(KeyCode.S))
        {
            duckRigidbody.AddForce(Vector3.back);
        }
        if(Input.GetKey(KeyCode.A))
        {
            duckRigidbody.AddForce(Vector3.left);
        }
        if(Input.GetKey(KeyCode.D))
        {
            duckRigidbody.AddForce(Vector3.right);
        }
    }
}
