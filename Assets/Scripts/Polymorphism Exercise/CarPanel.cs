using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPanel : ButtonsPanel
{
    public override void OnBlueButtonCLick()
    {
        base.OnBlueButtonCLick();
        
        Debug.Log("Fechou o vidro!");
    }

    public override void OnRedButtonClick()
    {
        base.OnRedButtonClick();
        
        Debug.Log("Buzinou!");

    }
}
