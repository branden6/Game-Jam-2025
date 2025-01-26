using UnityEngine;

public class GermMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

public Transform targetObj;
public float movementSpeed = 1.25f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, movementSpeed * Time.deltaTime);
        
        Vector3 direction = (targetObj.position - transform.position).normalized;
        
        // Ensure the direction doesn't have vertical tilt (if needed)
        direction.y = 0; 
        
        // Rotate towards the target
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 5f); // Smooth rotation
        }
    }
  
}
