using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobePanel : ButtonsPanel
{
    [SerializeField] private Animation _leftSideDoorAnimation;
    [SerializeField] private AnimationClip _leftDoorOpen;
    [SerializeField] private AnimationClip _leftDoorClose;
    
    [SerializeField] private Animation _rightSideDoorAnimation;
    [SerializeField] private AnimationClip _rightDoorOpen;
    [SerializeField] private AnimationClip _rightDoorClose;
    
    public void OnDoorLeftClick(bool isOpen)
    {
        if(isOpen)
        {
            base.OnRedButtonClick();

            _leftSideDoorAnimation.clip = _leftDoorClose;
            _leftSideDoorAnimation.Play();

            _rightSideDoorAnimation.clip = _rightDoorClose;
            _rightSideDoorAnimation.Play();
        }
        else
        {
           base.OnBlueButtonCLick();

           _leftSideDoorAnimation.clip = _leftDoorOpen;
           _leftSideDoorAnimation.Play();
           
           _rightSideDoorAnimation.clip = _rightDoorOpen;
           _rightSideDoorAnimation.Play();
        }
    }
}
