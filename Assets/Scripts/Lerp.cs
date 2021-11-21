using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lerp : MonoBehaviour
{
    [SerializeField] private GameObject _vector1;
    [SerializeField] private GameObject _vector2;

    [SerializeField] private Text _vector1Text;

    [SerializeField] private float _amount;

    [SerializeField] private bool _doLerp;

    private Coroutine lerpRoutine;
    private void Update()
    {
        if (_doLerp && lerpRoutine == null)
        {
            lerpRoutine = StartCoroutine(DoLerpMotion());
        }
    }

    private IEnumerator DoLerpMotion()
    {
        Vector3 v2v1 = _vector2.transform.position - _vector1.transform.position;

        string originalText = _vector1Text.text;
        Vector3 originalPos = _vector1.transform.position;

        int textTutorialCounter = 0;
        /*while (v2v1.magnitude > 0.01f)
        {
            if (textTutorialCounter < 3)
            {
                _vector1Text.text = "Passo1: Calcular distância (em preto)";
                yield return new WaitForSeconds(2f);

                _vector1Text.text = "Passo2: Transladar pra lá";
                yield return new WaitForSeconds(1f);
            }
            _vector1.transform.position = Vector3.Lerp(_vector1.transform.position, _vector2.transform.position, _amount);

            if (textTutorialCounter < 3)
            {
                _vector1Text.text = "Passo3: Repetir";
                yield return new WaitForSeconds(1f);
            }

            v2v1 = _vector2.transform.position - _vector1.transform.position;
            textTutorialCounter++;
            yield return new WaitForSeconds(0.1f);
        }

        _vector1.transform.position = originalPos;*/

        v2v1 = _vector2.transform.position - _vector1.transform.position;
        _vector1Text.text = "Agora rápido!";
        yield return new WaitForSeconds(2f);

        while (v2v1.magnitude > 0.01f)
        {
            _vector1.transform.position = Vector3.Lerp(_vector1.transform.position, _vector2.transform.position, _amount);
            v2v1 = _vector2.transform.position - _vector1.transform.position;
            yield return new WaitForSeconds(0.05f);
        }
        
        _vector1Text.text = originalText;
        lerpRoutine = null;
        _doLerp = false;
    }

    private void OnDrawGizmos()
    {
        Vector3 v2v1 = _vector2.transform.position - _vector1.transform.position;
        
        Gizmos.color = Color.black;
        Gizmos.DrawLine(_vector1.transform.position, _vector1.transform.position + (v2v1 * _amount));
        
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(_vector1.transform.position + (v2v1 * _amount), _vector2.transform.position);
    }
}
