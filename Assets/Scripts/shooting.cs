using Unity.VisualScripting;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public Rigidbody sphere;
    public Vector3 aimingDir;
    public float velocity = 10f;
    public float fireRate = 1f; // setting it to zero makes it a laser beam
    private float nextTimeFireRate = 0f;
    public GameObject Click_Plane;
    public GameObject shootPoint;
    public GameObject DuckModel;

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

    void Update()
    {
        Click_Plane.transform.position = transform.position;
        Click_Plane.transform.localScale = new Vector3(cam.orthographicSize * 2f, 1f, cam.orthographicSize * 2f);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit aim))
        {
            aimingDir = new Vector3(aim.point.x, transform.position.y, aim.point.z) - transform.position;
            Debug.DrawLine(transform.position, new Vector3(aim.point.x, transform.position.y, aim.point.z));
        }

        if (Input.GetMouseButton(0) && Time.time >= nextTimeFireRate)
        {
            nextTimeFireRate = Time.time + fireRate;

            Rigidbody rb = Instantiate(sphere, shootPoint.transform.position, Quaternion.identity);
            rb.linearVelocity = aimingDir.normalized * velocity; // Fixed to use `velocity`
        }

        Quaternion rotation = Quaternion.LookRotation(aimingDir, Vector3.up);
        DuckModel.transform.rotation = rotation;
    }
}


