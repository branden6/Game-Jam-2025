using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public GameObject sphere;

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
        //check if the left mouse button is clicked.
        if (Input.GetMouseButtonDown(0))
        {
            // shoot a raycast from the camera through the mouse position.
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // If the raycast hits something, spawn the point at the hit location.
                Instantiate(sphere, hit.point, Quaternion.identity);

                //need function to ignore player
            }
        }
    }
}
