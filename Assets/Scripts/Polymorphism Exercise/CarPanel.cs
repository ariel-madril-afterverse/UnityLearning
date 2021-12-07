using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPanel : ButtonsPanel
{
    [SerializeField] private AudioSource _audioSource;
  
    public override void OnBlueButtonCLick()
    {
        base.OnBlueButtonCLick();
        
        Debug.Log("Fechou o vidro!");
    }

    public override void OnRedButtonClick()
    {
        base.OnRedButtonClick();
        
        _audioSource.Play();
        
        Debug.Log("Buzinou!");

    }
}
