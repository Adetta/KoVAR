using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    public Button Button;
    public Image IdleSprite;
    public Image PressedSprite;

    public NavigationButtonsController.ButtonType Type;

    public event System.Action<NavigationButtonsController.ButtonType> Clicked;

    protected void Awake()
    {
        Reset();
    }

    public void Reset()
    {
        IdleSprite.gameObject.SetActive(true);
        PressedSprite.gameObject.SetActive(false);
    }

    public void Press()
    {
        IdleSprite.gameObject.SetActive(false);
        PressedSprite.gameObject.SetActive(true);
    }

    public virtual void OnClicked()
    {
        var handler = Clicked;
        if (handler != null)
        {
            handler(Type);
        }
    }
}
