using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemTypeViewRepository : MonoBehaviour
{
    [SerializeField] private List<ItemTypeSpritePair> _pairs;

    private static List<ItemTypeSpritePair> _staticPairs;

    private void Awake()
    {
        _staticPairs = _pairs;
    }

    public static Sprite GetSpriteByType(ItemType type)
    {
        var pair = _staticPairs.First((pairType) => pairType.Type == type);
        var sprite = pair.Sprite;

        return sprite;
    }
}