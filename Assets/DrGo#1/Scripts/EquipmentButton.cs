using System;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentButton : MonoBehaviour
{
    private EquipmentTemplate equipment;
    private NavigationView navigationView;
    private RectTransform rectDetails;

    public void Setup(EquipmentTemplate equipment, NavigationView navigationView, RectTransform rectDetails)
    {
        this.equipment = equipment;
        this.navigationView = navigationView;
        this.rectDetails = rectDetails;

        GetComponent<Button>().onClick.AddListener(OnClickBtnEvent);
    }
    public void OnClickBtnEvent()
    {
        rectDetails.GetComponent<Equipment>().Setup(equipment);
        navigationView.Push(rectDetails);
    }
}
