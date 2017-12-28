using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UIRoot : MonoBehaviour
{
    private Dictionary<NavigationButtonsController.ButtonType, BasePanel> Panels;
    private BasePanel currentPanel;

    public List<BasePanel> PanelList;
    public NavigationButtonsController Navigation;

    protected void Awake()
    {
        Panels = new Dictionary<NavigationButtonsController.ButtonType, BasePanel>();
        /*        foreach (var panelPrefab in PanelList)
                {
                    var panel = Instantiate(panelPrefab);
                    panel.transform.SetParent(this.transform, false);
                    //panel.transform.localPosition = Vector3.zero;
                    Panels.Add(panel.Type, panel);            
                }*/
        foreach (var panel in PanelList)
        {
            Panels.Add(panel.Type, panel);
        }
        Navigation.OnTransition += NavigationOnTransition;
    }

    private void NavigationOnTransition(NavigationButtonsController.ButtonType type)
    {      
        if (currentPanel && currentPanel.Type == type)
        {
            return;
        }
        if (currentPanel)
        {
            currentPanel.Hide();
        }
        currentPanel = Panels[type];
        currentPanel.Show();
    }

    private void Reset()
    {
        foreach (var panel in Panels.Values)
        {
            panel.Hide();
        }
    }

    // Use this for initialization
    protected void Start()
    {
        Reset();
        Navigation.ButtonPress(NavigationButtonsController.ButtonType.Help);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
