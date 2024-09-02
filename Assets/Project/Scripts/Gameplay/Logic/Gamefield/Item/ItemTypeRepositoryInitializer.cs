using UnityEngine;

public class ItemTypeRepositoryInitializer : MonoBehaviour
{
    private void Awake()
    {
        ItemTypeRepository.Reset();
    }
}