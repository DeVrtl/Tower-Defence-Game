using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OpenPanel(GameObject panel)
    {
        PanelActivator(panel, true, 0);
    }

    public void ClosePanel(GameObject panel)
    {
        PanelActivator(panel, false, 1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void PanelActivator(GameObject panel, bool resualt, int number)
    {
        panel.SetActive(resualt);
        Time.timeScale = number;
    }
}
