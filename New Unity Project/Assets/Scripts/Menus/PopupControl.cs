using UnityEngine;
using UnityEngine.UI;

public abstract class PopupControl : MonoBehaviour
{
    public Vector3 panelPosition;
    public bool visible;
    public GameObject panel;
    public KeyCode key;

    public void Start()
    {
        panelPosition = new Vector3(gameObject.GetComponent<RectTransform>().anchoredPosition.x, gameObject.GetComponent<RectTransform>().anchoredPosition.y, 0);
        PopupScreenControls.HideScreen(panel);
        visible = false;
        Setup();
    }

    public abstract void Setup();

    public virtual void UpdateText()
    {

    }

    public virtual void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (visible == false)
            {
                UpdateText();
                PopupScreenControls.DisplayScreen(panel, panelPosition);
                PopupScreenControls.screensUp += 1;
                visible = true;
                PopupScreenControls.UpdatePauseStatus();
            }
            else
            {
                PopupScreenControls.HideScreen(panel);
                PopupScreenControls.screensUp -= 1;
                visible = false;
                PopupScreenControls.UpdatePauseStatus();
            }
        }
    }
}
