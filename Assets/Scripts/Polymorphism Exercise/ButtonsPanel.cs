using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsPanel : MetalPanel, IButtonPanel
{
    [SerializeField] private RawImage _blueLight;
    [SerializeField] private RawImage _redLight;

    public virtual void OnBlueButtonCLick()
    {
        _blueLight.color = Color.blue;
        StartCoroutine(BlinkLight(_blueLight));
    }

    public virtual void OnRedButtonClick()
    {
        _redLight.color = Color.red;
        StartCoroutine(BlinkLight(_redLight));
    }

    IEnumerator BlinkLight(RawImage _light)
    {
        yield return new WaitForSeconds(0.2f);
          _light.color = Color.white;  
    }
    
}
