using System;
using UnityEngine;

public class Progress : MonoBehaviour
{
    private const int Goal = 12;

    public static Action<int> Changed;

    public static int Value { get; private set; }
    public static int Target => Goal * Level.Value;

    public static bool Completed => Value >= Target;

    private void Awake()
    {
        Value = 0;

        Item.Clicked += Increase;
    }

    private void Increase()
    {
        Value++;
        Changed?.Invoke(Value);
    }

    private void OnDestroy()
    {
        Item.Clicked -= Increase;
    }
}