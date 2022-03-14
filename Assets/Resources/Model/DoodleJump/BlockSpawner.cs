using UnityEngine;

public class BlockSpawner
{
    private Vector3 _previousBlockPosition;
    private float _playerHeightSpawnOffset;
    
    public BlockSpawner(float playerHeightSpawnOffset)
    {
        _playerHeightSpawnOffset = playerHeightSpawnOffset;
    }

    public void Update(float playerYPosition)
    {

    }
}
