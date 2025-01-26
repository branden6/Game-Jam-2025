using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public Rigidbody sphere;
    public Vector3 aimingDir;
    public float velocity = 10f;
    public float fireRate = 1f; // setting it to zero makes it a lazer beam essentially
    private float nextTimeFireRate = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (cam == null)
        {
            cam = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // shoot a raycast from the camera through the mouse position.
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit aim))
        {
            aimingDir = new Vector3(aim.point.x, transform.position.y, aim.point.z) - transform.position;
            Debug.DrawLine(transform.position, new Vector3(aim.point.x, transform.position.y, aim.point.z));
        }

        //check if the left mouse button is clicked.
        if (Input.GetMouseButton(0) && Time.time >= nextTimeFireRate)
        {
            /*if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // If the raycast hits something, spawn the point at the hit location.
                Instantiate(sphere, hit.point, Quaternion.identity);
                
            }*/

            nextTimeFireRate = Time.time + fireRate;

            Rigidbody rb = Instantiate(sphere, transform.position, Quaternion.identity);
            rb.linearVelocity = aimingDir.normalized * velocity;
        }
        //need function to ignore player
    }
}
