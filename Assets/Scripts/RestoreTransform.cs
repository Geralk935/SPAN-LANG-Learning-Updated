using UnityEngine;

public class RestoreTransform : MonoBehaviour
{
    private Transform reference;

    private Vector3 storedPos;
    private Quaternion storedRot;

    void Awake()
    {
        reference = transform;
        storedPos = reference.position;
        storedRot = reference.rotation;
    }

    public void Restore()
    {
        transform.position = storedPos;
        transform.rotation = storedRot;
    }
}
