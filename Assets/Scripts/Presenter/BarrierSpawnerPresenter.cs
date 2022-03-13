using UnityEngine;

public class BarrierSpawnerPresenter : MonoBehaviour
{
    [SerializeField] private GameObject _barrierPrefab;
    [SerializeField] private Transform _playerPositions;
    [SerializeField] private float _playerHeightSpawnOffset;

    private BlockSpawner _blockSpawner;

    private void Awake()
    {
        _blockSpawner = new BlockSpawner(_playerHeightSpawnOffset);
    }

    private void Update()
    {
        _blockSpawner.Update(_playerPositions.position.y);
    }
}
