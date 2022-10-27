using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLinePiece : ClearablePiece
{
    public bool isRow;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Clear()
    {
        base.Clear();

        if (isRow)
        {
            piece.GridRef.ClearRow(piece.Y);
        }
        else
        {
            piece.GridRef.ClearColumn(piece.X);
        }
    }
}
