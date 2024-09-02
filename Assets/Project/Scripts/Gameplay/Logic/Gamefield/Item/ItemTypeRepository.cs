using System.Collections.Generic;
using UnityEngine;

public static class ItemTypeRepository
{
    private const int MinTargetCount = 3;
    private const int MaxTargetCount = 6;
    private const int ItemCount = 12;

    public static int TargetCount { get; private set; }

    private static readonly List<ItemType> _types = new List<ItemType>();

    public static void Reset()
    {
        _types.Clear();

        TargetCount = Random.Range(MinTargetCount, MaxTargetCount + 1);

        for (int i = 0; i < ItemCount; i++)
        {
            if(TargetCount > i)
            {
                _types.Add(ItemType.Target);
                continue;
            }

            _types.Add(ItemType.Idle);
        }
    }

    public static ItemType GetRandomType()
    {
        var index = Random.Range(0, _types.Count);

        var type = _types[index];
        _types.Remove(type);

        return type;
    }
}