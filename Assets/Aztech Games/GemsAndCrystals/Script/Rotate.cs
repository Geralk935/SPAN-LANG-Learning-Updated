using UnityEngine;

namespace AztechGames
{
public class Rotate : MonoBehaviour
{
    public float speed = 10f; // Speed of rotation in degrees per second
    void FixedUpdate() { transform.Rotate(Vector3.up, speed * Time.deltaTime); } // Rotate around the Y-axis
}
}