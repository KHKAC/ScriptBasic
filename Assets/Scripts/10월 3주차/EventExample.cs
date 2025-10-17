using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ButtonEvent
{
    public event EventHandler Click;
    public void MouseButtonDown()
    {
        if(this.Click != null)
        {
            Click(this, EventArgs.Empty);
        }
    }
}

public class EventExample : MonoBehaviour
{
    void Start()
    {
        ButtonEvent buttonEvent = new ButtonEvent();
        buttonEvent.Click += new EventHandler(ButtonClick);
        buttonEvent.Click += new EventHandler(ButtonClick);

        buttonEvent.MouseButtonDown();
        // buttonEvent.MouseButtonDown();
        // buttonEvent.MouseButtonDown();
    }

    void ButtonClick(object sender, EventArgs e)
    {
        Debug.Log("버튼 클릭!");
    }
}
