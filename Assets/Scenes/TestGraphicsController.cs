using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Copypasta;

public class TestGraphicsController : MonoBehaviour
{
    private void Update()
    {
        //Test circle
        Circle circle = new(transform.position, 1f);

        int circleRes = 8;

        DisplayGraphics.DrawCircle(circle, Materials.ColorOptions.White, Circle.Space2D.XY, circleRes);
        DisplayGraphics.DrawCircle(circle, Materials.ColorOptions.Blue, Circle.Space2D.XZ, circleRes);
        DisplayGraphics.DrawCircle(circle, Materials.ColorOptions.Red, Circle.Space2D.ZY, circleRes);



        //Test dots
        Random.InitState(0);

        List<Vector3> randomDots = new();

        for (int i = 0; i < 30; i++)
        {
            MinMax minMax = new(-5f, 5f);

            float randomX = Random.Range(minMax.min, minMax.max);
            float randomY = Random.Range(minMax.min, minMax.max);
            float randomZ = Random.Range(minMax.min, minMax.max);

            randomDots.Add(new Vector3(randomX, randomY, randomZ));
        }

        DisplayGraphics.DrawVertices(randomDots, Materials.ColorOptions.Green);
    }
}
