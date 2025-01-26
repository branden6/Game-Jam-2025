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
    }
  
}
