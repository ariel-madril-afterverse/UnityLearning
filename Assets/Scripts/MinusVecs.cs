using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusVecs : MonoBehaviour
{
    [SerializeField] private GameObject _vector1;
    [SerializeField] private GameObject _vector2;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(_vector1.transform.position , _vector2.transform.position);

        Vector3 minusVec = _vector2.transform.position - _vector1.transform.position;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero , minusVec);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.zero , _vector1.transform.forward);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero , _vector1.transform.position);
    }
}
