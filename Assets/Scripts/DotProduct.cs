using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class DotProduct : MonoBehaviour
{
    [SerializeField] private CrossProduct _crossProduct;
    [SerializeField] private GameObject _vector1;
    [SerializeField] private GameObject _vector2;
    [SerializeField] private Canvas _resultCanvas;
    [SerializeField] private Text _resultText;
    [SerializeField] private bool _resultInAngles;
    [SerializeField] private bool _useFull360;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, _vector1.transform.position);

        float resultDot = Vector3.Dot(_vector1.transform.position, _vector2.transform.position);

        Vector3 projectionLength = _vector2.transform.position * resultDot;


        if (resultDot < 0)
        {
            Gizmos.color = Color.black;
            Gizmos.DrawLine(projectionLength,Vector3.zero);
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(Vector3.zero, _vector2.transform.position);
        }
        else
        {
            if (projectionLength.magnitude <= _vector2.transform.position.magnitude)
            {
                Gizmos.color = Color.black;
                Gizmos.DrawLine(Vector3.zero, projectionLength);
                
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(projectionLength, _vector2.transform.position);
            }
            else
            {
                Gizmos.color = Color.black;
                Gizmos.DrawLine(Vector3.zero, projectionLength);
            }
        }
        
        _resultCanvas.transform.position = new Vector3(projectionLength.x, projectionLength.y + 0.1f, projectionLength.z);

        if (_resultInAngles)
        {
            float remappedDot = (1 + resultDot) / 2;

            if (_useFull360)
            {
                if (_crossProduct._resultCrossProduct.y > 0)
                {
                    _resultText.text = "Result: " + (180 - (180 * remappedDot));
                }
                else
                {
                    _resultText.text = "Result: " + (180 + (180 * remappedDot));
                }
            }
            else
            {
                _resultText.text = "Result: " + (180 - (180 * remappedDot));
            }
        }
        else
        {
            _resultText.text = "Result: " + resultDot;
        }
    }
}
