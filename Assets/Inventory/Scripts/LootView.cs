using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _date;

    public void Render(Loot loot)
    {
        _image.sprite = loot.Image;
        _date.text = loot.CreationTime.ToString();
    }
}
