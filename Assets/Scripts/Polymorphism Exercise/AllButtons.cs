using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllButtons : MonoBehaviour
{
    private List<IButtonPanel> _listButtons = new List<IButtonPanel>();
    
    void Start()
    {
        ButtonsPanel[] obj = FindObjectsOfType<ButtonsPanel>();
        foreach (ButtonsPanel buttonPanel in obj)
        {
            _listButtons.Add(buttonPanel);
        }

        StartCoroutine(SetALlButtonsClick());
    }

    IEnumerator SetALlButtonsClick()
    {
        yield return new WaitForSeconds(0.5f);

        foreach (IButtonPanel buttonsPanel in _listButtons)
        {
            buttonsPanel.OnRedButtonClick();
        }
    }
}
