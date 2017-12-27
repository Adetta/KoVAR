using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationButtonsController : MonoBehaviour
{
    public enum ButtonType {
        Help,
        Camera,
        About
    }

    public MyButton HelpBtn;
    public MyButton CameraBtn;
    public MyButton AboutBtn;

    public event System.Action<ButtonType> OnTransition;

    // before first render
    protected void OnEnable()
    {
        
    }

    // 
    protected void Awake()
    {
        HelpBtn.Clicked += ButtonPressInternal;
        CameraBtn.Clicked += ButtonPressInternal;
        AboutBtn.Clicked += ButtonPressInternal;
    }

    // Use this for initialization
    protected void Start ()
    {
		
	}

    // Update is called once per frame
    protected void Update ()
    {
		
	}

    private void ButtonPressInternal(ButtonType type)
    {
        ButtonPress(type);
    }

    public void ButtonPress(ButtonType type, bool silence = false)
    {
        Reset();
        switch (type)
        {
            case ButtonType.Help:
                HelpBtn.Press();
                break;
            case ButtonType.Camera:
                CameraBtn.Press();
                break;
            case ButtonType.About:
                AboutBtn.Press();
                break;
            default:
                break;
        }
        if (!silence)
        {
            OnOnTransition(type);
        }
    }

    private void Reset()
    {
        HelpBtn.Reset();
        CameraBtn.Reset();
        AboutBtn.Reset();
    }

    public virtual void OnOnTransition(ButtonType type)
    {
        var handler = OnTransition;
        if (handler != null)
        {
            handler(type);
        }
    }
}
