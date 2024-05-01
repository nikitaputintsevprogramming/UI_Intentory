using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LootsListView : MonoBehaviour
{
    [SerializeField] private LootView _template;
    [SerializeField] private Transform _container;
    [SerializeField] private Sprite _defaultSprite;

    private void Awake()
    {
        Render(new List<Loot>()
        {
            new Loot(_defaultSprite, DateTime.Now),
            new Loot(_defaultSprite, DateTime.Now),
            new Loot(_defaultSprite, DateTime.Now),
        });
    }

    private void Render(IEnumerable<Loot> loots)
    {
        foreach(var loot in loots)
        {
            LootView lootView = Instantiate(_template, _container);
            lootView.Render(loot);
        }
    }
}
