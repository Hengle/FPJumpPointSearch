﻿using UnityEngine;
using System.Collections;
using TrueSync;
public class JumpPoint : MonoBehaviour
{
    [SerializeField]
    private int _nodeAmountX;

    [SerializeField]
    private int _nodeAmountY;

    [SerializeField]
    private FP _nodeUnitSize;

    [SerializeField]
    private Transform _gridTransform;

    [SerializeField]
    private LayerMask _unwalkableLayerMask;

    private Grid _grid;

    public void InitializeGrid()
    {
        _grid = Grid.Instance;
        _grid.InitializeGrid(_gridTransform, _unwalkableLayerMask, _nodeUnitSize, _nodeAmountX, _nodeAmountY);
    }
}
