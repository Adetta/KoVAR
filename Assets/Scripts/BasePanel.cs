using UnityEngine;
using System.Collections;

public class BasePanel : MonoBehaviour
{

    public NavigationButtonsController.ButtonType Type;
// TODO: instantiate prefab here
//    public GameObject Prefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
