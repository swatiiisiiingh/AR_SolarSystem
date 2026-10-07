using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float orbitSpeed = 40f;

    void Update()
    {
        transform.Rotate(Vector3.up, orbitSpeed * Time.deltaTime);
    }
}