using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionMenu : MonoBehaviour
{
    public Button yourButton;
    public GameObject panel;
    bool isActive = false;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if(!isActive)
        {
            panel.SetActive(true);
            isActive = true;
        }
        else
        {
            panel.SetActive(false);
            isActive = false;
        }
        

    }
}
