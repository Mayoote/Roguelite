using Com.IsartDigital.Roguelite.GridElement;
using Godot;
using System;

// Author : Maïtson PIERRE

namespace Com.IsartDigital.Roguelite.GridElement;

   public partial class Floor : Node2D
{
    public Vector2 Size { get; private set; }
    [Export] public Sprite2D renderer;

    public override void _Ready()
    {
        if (renderer != null) Size = renderer.Texture.GetSize();
        else Size = Vector2.Zero;

        GD.Print("FLOOR SIZE : " + Size);
    }

    //public Floor() : base(new Vector2I()) 
    //{

    //}

}
