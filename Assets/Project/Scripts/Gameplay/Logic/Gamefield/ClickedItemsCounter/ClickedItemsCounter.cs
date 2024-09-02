using System;
using UnityEngine;

public class ClickedItemsCounter : MonoBehaviour
{
    public static Action AllClicked;

    public static int Count { get; private set; }

    private void Awake()
    {
        Count = default;
        Item.Clicked += IncreaseCount;
    }

    private void IncreaseCount()
    {
        Count++;

        if (Count < ItemTypeRepository.TargetCount) return;
        AllClicked?.Invoke();
        Reset();
    }

    private void Reset()
    {
        Count = 0;
    }

    private void OnDestroy()
    {
        Item.Clicked -= IncreaseCount;
    }
}