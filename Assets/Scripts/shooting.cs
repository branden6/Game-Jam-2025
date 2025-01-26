using Unity.VisualScripting;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public Rigidbody sphere;
    public Vector3 aimingDir;
    public float velocity = 10f;
    public float fireRate = 1f; // setting it to zero makes it a lazer beam essentially
    private float nextTimeFireRate = 0f;
    public GameObject Click_Plane;
    public GameObject shootPoint;
    public GameObject DuckModel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (cam == null)
        {
            cam = Camera.main;
        }
    }
    
    private void Awake()
    {
        Click_Plane.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Click_Plane.transform.position = transform.position;
        Click_Plane.transform.localScale = new Vector3(cam.orthographicSize * 2f, 1f, cam.orthographicSize * 2f);

        // shoot a raycast from the camera through the mouse position.
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit aim))
        {
            /*if (aim.transform.CompareTag("Click_Plane"))
            {
                Debug.Log("plane");
            }*/
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

            Rigidbody rb = Instantiate(sphere, shootPoint.transform.position, Quaternion.identity);
            rb.linearVelocity = aimingDir.normalized * velocity;
        }

        Quaternion Rotation = Quaternion.LookRotation(aimingDir, Vector3.up);
        DuckModel.transform.rotation = Rotation;
        //need function to ignore player
    }
}
