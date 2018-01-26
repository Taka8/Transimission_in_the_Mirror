using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTransform : MonoBehaviour
{

    [SerializeField] Transform target;
    float centerX;

    void Start()
    {
        centerX = (target.position.x + transform.position.x) / 2;
    }

    void LateUpdate()
    {
        ApplyMirroringPosition();

        ApplyMirroringRotation();
    }

    void ApplyMirroringPosition()
    {
        Vector3 targetPosition = target.position;

        targetPosition.Set(centerX - targetPosition.x, targetPosition.y, targetPosition.z);

        transform.position = targetPosition;
    }

    void ApplyMirroringRotation()
    {
        Vector3 eulerRotation = target.rotation.eulerAngles;

        transform.rotation = Quaternion.Euler(eulerRotation.x, -eulerRotation.y, eulerRotation.z);
    }

}
