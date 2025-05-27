using Com.IsartDigital.Roguelite.GridElement;
using Com.IsartDigital.Roguelite.Tools;
using Godot;
using System;

// Author : Maïtson PIERRE

namespace Com.IsartDigital.Roguelite;

   public partial class Main : Node2D
{
    private Grid grid;
    private Floor floor;
    public override void _Ready()
    {
        grid = new Grid();
        //floor = (Floor)grid.map[0, 0];

        for (int x = 0; x < grid.map.Length; x++)
        {
            for (int y = 0; y < grid.map.Length; y++)
            {
                PackedScene lFloorFactory = GD.Load<PackedScene>(Path.FLOOR_PATH);
                Floor lFloor = lFloorFactory.Instantiate<Floor>();
                AddChild(lFloor);


                //lFloor.Position = grid.map[y, x].Position;
                lFloor.GlobalPosition = grid.map[y, x].GlobalPosition;
            }
        }
    }
}
