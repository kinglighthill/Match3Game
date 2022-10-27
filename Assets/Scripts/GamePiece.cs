using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    public int score;

    private int x;
    private int y;
    private Grid.PieceType type;
    private Grid grid;
    private MovablePiece moveableComponent;
    private ColorPiece colorComponent;
    private ClearablePiece clearableComponent;

    public int X
    {
        get { return x;  }
        set
        {
            if (IsMovable())
            {
                x = value;
            }
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (IsMovable())
            {
                x = value;
            }
        }
    }

    public Grid.PieceType Type
    {
        get { return type; }
    }

    public Grid GridRef
    {
        get { return grid; }
    }

    public MovablePiece MovableComponent
    {
        get { return moveableComponent; }
    }

    public ColorPiece ColorComponent
    {
        get { return colorComponent; }
    }

    public ClearablePiece ClearableComponent
    {
        get { return clearableComponent; }
    }

    private void Awake()
    {
        moveableComponent = GetComponent<MovablePiece>();
        colorComponent = GetComponent<ColorPiece>();
        clearableComponent = GetComponent<ClearablePiece>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        grid.EnterPiece(this);
    }

    private void OnMouseDown()
    {
        grid.PressPiece(this);
    }

    private void OnMouseUp()
    {
        grid.ReleasePiece();
    }

    public void Init(int x, int y, Grid grid, Grid.PieceType type)
    {
        this.x = x;
        this.y = y;
        this.grid = grid;
        this.type = type;
    }

    public bool IsMovable()
    {
        return moveableComponent != null;
    }

    public bool IsColoured()
    {
        return colorComponent != null;
    }

    public bool IsClearable()
    {
        return clearableComponent != null;
    }
}
