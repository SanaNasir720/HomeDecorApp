using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaseSelection : MonoBehaviour
{
    public Button yourButton;
    public GameObject indicator;
    public GameObject vase;
    bool isActive = false;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        indicator.GetComponent<IndicatorBehaviourController>().objectToPlace = vase;


    }
}
