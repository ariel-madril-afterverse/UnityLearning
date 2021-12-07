using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetalPanel : MonoBehaviour
{
    [SerializeField] private Image _panelRenderer;
    void Start()
    {
        _panelRenderer.material.SetColor("_Color", Color.gray);
    }
}
