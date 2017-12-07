using UnityEngine;

public static class PopupScreenControls
{
    public static int screensUp;
    public static Vector3 hiddenPosition = new Vector3(9999, 9999, 0);
    
    public static void UpdatePauseStatus()
    {
        if (screensUp > 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public static void HideScreen(GameObject panel)
    {
        panel.GetComponent<RectTransform>().anchoredPosition = hiddenPosition;
    }

    public static void DisplayScreen(GameObject panel, Vector3 position)
    {
        panel.GetComponent<RectTransform>().anchoredPosition = position;
    }
}
