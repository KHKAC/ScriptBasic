using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    #region public field
    public Image graphic;

    #region Sprites
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    #endregion
    
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    // public TMP_Text downTxt;
    // public TMP_Text heldTxt;
    // public TMP_Text upTxt;

    #endregion

    #region Method
    void Start()
    {
        graphic.sprite = standard;
    }

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + up;
    }
    #endregion
}
