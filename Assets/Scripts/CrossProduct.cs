using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CrossProduct : MonoBehaviour
{
    [SerializeField] private GameObject _vector1;
    [SerializeField] private GameObject _vector2;
    [SerializeField] private Canvas _resultCanvas;
    [SerializeField] private Text _resultText;

    [HideInInspector] public Vector3 _resultCrossProduct;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, _vector1.transform.position);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, _vector2.transform.position);

        Gizmos.color = Color.gray;
        Vector3 v1v2 = _vector1.transform.position + _vector2.transform.position;
        Gizmos.DrawLine(_vector1.transform.position, v1v2);
        Gizmos.DrawLine(_vector2.transform.position, v1v2);
        
        Gizmos.color = Color.blue;

        _resultCrossProduct = Vector3.Cross(_vector1.transform.position, _vector2.transform.position);
        Gizmos.DrawLine(Vector3.zero, _resultCrossProduct);
        _resultCanvas.transform.position = _resultCrossProduct;
        _resultText.text = "Result: " + _resultCrossProduct.x.ToString() + ", " + _resultCrossProduct.y + ", " + _resultCrossProduct.z;
    }
}
