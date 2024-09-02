using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static event Action Clicked;

    private bool _isClicked;

    public ItemType Type { get; private set; }

    public void Reset()
    {
        _isClicked = false;
        Type = ItemTypeRepository.GetRandomType();
    }

    public bool TryClick()
    {
        if (Type != ItemType.Target) return false;
        if (_isClicked) return false;

        _isClicked = true;
        Clicked?.Invoke();

        return true;
    }
}