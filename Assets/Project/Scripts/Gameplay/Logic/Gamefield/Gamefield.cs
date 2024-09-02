using System.Collections.Generic;
using UnityEngine;

public class Gamefield : MonoBehaviour
{
    [SerializeField] private List<ItemView> _items;

    public void Reset()
    {
        ItemTypeRepository.Reset();

        foreach (var item in _items)
        {
            item.Actualize();
        }
    }

    private void Start()
    {
        Reset();

        ClickedItemsCounter.AllClicked += Reset;
    }

    private void OnDestroy()
    {
        ClickedItemsCounter.AllClicked -= Reset;        
    }
}