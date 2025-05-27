using Godot;
using System;

// Author : Maïtson PIERRE

namespace Com.IsartDigital.Roguelite.GridElement;

   public partial class Grid
{
    public Tile[,] map;
    private Vector2 tileSize;
    private int nRow = 10;
    private int nColumn = 10;
    public Grid()
    {
        CreateGrid(nRow, nColumn);
    }

    public Tile[,] CreateGrid(int pRow, int pColumn)
    {

        Vector2I lTileIndexPosition;
        Vector2 lTilePosition;

        map = new Tile[pRow, pColumn];

        for (int x = 0; x < pRow; x++)
        {
            for (int y = 0; y < pColumn; y++)
            {
                lTileIndexPosition = new Vector2I(x, y);
                map[y, x] = new Tile(lTileIndexPosition);
                //Floor lFloor = (Floor)map[y, x];

                lTilePosition = new Vector2 (
                    map[y,x].CenterPosition.X + map[y, x].Size.X * x,
                    map[y,x].CenterPosition.Y + map[y, x].Size.Y * y
                    );


                //map[y, x].Position = new(
                //    map[y, x].Position.X + map[y, x].Size.X,
                //    map[y, x].Position.Y
                //    );

                map[y, x].GlobalPosition = lTilePosition;
                GD.Print("TILE POSITION : " + map[y, x].GlobalPosition);

                

                //GD.Print("FLOOR POSITION : " + map[y, x].floor.GlobalPosition);
            }
        }

        return map;
    }
}
