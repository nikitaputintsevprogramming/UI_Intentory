using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDragSource 
{
    Sprite GetItem();
    void RemoveItem();
}
