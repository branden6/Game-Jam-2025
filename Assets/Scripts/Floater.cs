using UnityEngine;

public class Floater : MonoBehaviour

{
    public Rigidbody rigidBody;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;
    private void FixedUpdate() 
    {
       
        float waveHeight = WaveManager.Instance.GetWaveHeight(transform.position.x);
        
        if (transform.position.y < waveHeight) 
        { 
          float displacementMultiplier = Mathf.Clamp01((waveHeight-transform.position.y) / depthBeforeSubmerged) * displacementAmount;
          rigidBody.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
    }
}
