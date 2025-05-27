using Com.IsartDigital.Roguelite.Tools;
using Godot;
using System;

// Author : Maïtson PIERRE

namespace Com.IsartDigital.Roguelite.GridElement;

   public partial class Tile : Node2D
{
    public Vector2I IndexPosition { get; protected set; }
	public Vector2 CenterPosition { get; private set; }
	public Vector2 Size { get; private set; }

    public enum TileType 
    {
        EMPTY, FILLED
    }

    public Tile(Vector2I pIndexPosition, TileType pTileType)
    {
        SetupTile(pIndexPosition);
        //IndexPosition = pIndexPosition;
    }



    private void SetupTile(Vector2I pIndexPosition)
    {
        //containedObject.renderer = (Sprite2D)FindChild(Path.RENDERER_PATH);

        //if (renderer != null) Size = renderer.Texture.GetSize();
        //else Size = Vector2.Zero;

        IndexPosition = pIndexPosition;

        //PackedScene lFloorFactory = GD.Load<PackedScene>(Path.FLOOR_PATH);
        //Floor lFloor = lFloorFactory.Instantiate<Floor>();
        //AddChild(lFloor);

        Size = new(64,64);
        CenterPosition = Size * .5f;

       // lFloor = floor;
        GD.Print(IndexPosition);
        GD.Print(Size);
        GD.Print(CenterPosition);
    }
}
