using UnityEngine;

public enum EquipmentGrade { Normal, Magic, Rare, Set, Unique, Count }

[System.Serializable]
public class EquipmentTemplate
{
    public EquipmentGrade grade;
    public string iconFile;
    public string name;
    public int price;
    [TextArea(0, 30)]
    public string details;
}
