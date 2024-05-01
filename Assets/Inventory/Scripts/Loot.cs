using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class Loot
{
    private Sprite _image;
    private DateTime _creationTime;

    public Loot(Sprite image, DateTime creationTime)
    {
        _image = image;
        _creationTime = creationTime;
    }

    public Sprite Image => _image;
    public DateTime CreationTime => _creationTime;
}
