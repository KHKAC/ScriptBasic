using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControl : MonoBehaviour
{
    [SerializeField] TMP_Text titleTxt;
    [SerializeField] Toggle toggle1;
    [SerializeField] Slider slider;
    [SerializeField] Button btn;
    [SerializeField] TMP_Dropdown dropdown;

    void Start()
    {
        titleTxt.text = "This is Title";
    }

    public void OnToggle1Clicked()
    {
        Debug.Log("Toggle 1 is clicked.");
        if (toggle1.isOn)
        {
            Debug.Log("Toggle 1 is switched on.");
        }
        else
        {
            Debug.Log("Toggle 1 is switched off.");
        }

    }

    public void OnSliderChanged()
    {
        Debug.Log(slider.value);
    }

    public void OnButtonClicked()
    {
        Debug.Log("Button is clicked");
    }

    public void OnDropdownClicked()
    {
        Debug.Log(dropdown.value);
    }

    public void OnImageClicked()
    {
        Debug.Log("Image is Clicked");
    }
}
