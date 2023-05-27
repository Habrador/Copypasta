using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Copypasta;

public class TestGraphicsController : MonoBehaviour
{
    private void Update()
    {
        Random.InitState(0);

        //Test circle
        //Will also test DrawLines() because its whats used to draw the cirle
        Circle circle = new(transform.position, 1f);

        DisplayGraphics.DisplayCircle3D(circle, Materials.ColorOptions.Red, resolution: 8);



        //Test DrawVertices()
        List<Vector3> randomVertices = new();

        MinMax minMax = new(-5f, 5f);

        for (int i = 0; i < 30; i++)
        {
            Vector3 randomPos = GetRandomPos(minMax);

            randomVertices.Add(randomPos);
        }

        DisplayGraphics.DisplayVertices(randomVertices, Materials.ColorOptions.Pink);



        //Test DrawLineSegments()
        List<LineSegment3> lineSegments = new();

        for (int i = 0; i < 5; i++)
        {
            Vector3 p1 = GetRandomPos(minMax);
            Vector3 p2 = GetRandomPos(minMax);

            lineSegments.Add(new LineSegment3(p1, p2));
        }

        DisplayGraphics.DisplayLineSegments(lineSegments, Materials.ColorOptions.Yellow);
    }



    private Vector3 GetRandomPos(MinMax minMax)
    {
        float randomX = Random.Range(minMax.min, minMax.max);
        float randomY = Random.Range(minMax.min, minMax.max);
        float randomZ = Random.Range(minMax.min, minMax.max);

        Vector3 randomPos = new(randomX, randomY, randomZ);

        return randomPos;
    }
}
