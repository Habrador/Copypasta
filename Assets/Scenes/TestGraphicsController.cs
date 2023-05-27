using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Copypasta;

public class TestGraphicsController : MonoBehaviour
{
    private void Update()
    {
        Circle circle = new(transform.position, 1f);

        DisplayGraphics.DrawCircle(circle, Materials.ColorOptions.White, Circle.Space2D.XY);
        DisplayGraphics.DrawCircle(circle, Materials.ColorOptions.Blue, Circle.Space2D.XZ);
        DisplayGraphics.DrawCircle(circle, Materials.ColorOptions.Red, Circle.Space2D.ZY);
    }
}
