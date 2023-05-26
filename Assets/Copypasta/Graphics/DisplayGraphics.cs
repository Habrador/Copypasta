using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Copypasta
{
    public class DisplayGraphics
    {
        //
        // Draw a circle 
        //
        
        //The circle can become a triangle if you lower resolution
        public enum Space2D { XY, XZ, ZY };

        public static void DrawCircle(Circle circle, Materials.ColorOptions color, Space2D space, int resolution = 100)
        {
            //Generate the vertices and the indices
            List<Vector3> vertices = new();
            List<int> indices = new();

            float angleStep = 360f / resolution;

            float angle = 0f;

            for (int i = 0; i < resolution + 1; i++)
            {
                float x = circle.radius * Mathf.Cos(angle * Mathf.Deg2Rad);
                float y = circle.radius * Mathf.Sin(angle * Mathf.Deg2Rad);

                Vector3 vertex = new Vector3(x, y, 0f) + circle.center;

                if (space == Space2D.ZY)
                {
                    vertex = new Vector3(0f, y, x) + circle.center;
                }
                else if (space == Space2D.XZ)
                {
                    vertex = new Vector3(x, 0f, y) + circle.center;
                }


                vertices.Add(vertex);
                indices.Add(i);

                angle += angleStep;
            }

            //Generate the mesh
            Mesh m = new();

            m.SetVertices(vertices);
            m.SetIndices(indices, MeshTopology.LineStrip, 0);

            //Display the mesh
            Material material = Materials.GetMaterial(color);

            Graphics.DrawMesh(m, Vector3.zero, Quaternion.identity, material, 0, Camera.main, 0);
        }



        //
        // Draw a line consisting of several vertices
        //
        
        //If they line consists of A-B-C-D, the vertices are A,B,C,D
        public static void DrawLine(List<Vector3> vertices, Materials.ColorOptions color)
        {
            //Display the mesh
            Material material = Materials.GetMaterial(color);

            DrawLine(vertices, material);
        }

        public static void DrawLine(List<Vector3> vertices, Material material)
        {
            if (vertices.Count < 2)
            {
                return;
            }

            //Generate the indices
            List<int> indices = new();

            for (int i = 0; i < vertices.Count; i++)
            {
                indices.Add(i);
            }

            //Generate the mesh
            Mesh m = new();

            m.SetVertices(vertices);
            m.SetIndices(indices, MeshTopology.LineStrip, 0);

            Graphics.DrawMesh(m, Vector3.zero, Quaternion.identity, material, 0, Camera.main, 0);
        }



        //
        // Draw vertices
        //
        
        public static void DrawVertices(List<Vector3> vertices, Material material)
        {
            //Generate the indices
            List<int> indices = new();

            for (int i = 0; i < vertices.Count; i++)
            {
                indices.Add(i);
            }

            //Generate the mesh
            Mesh m = new();

            m.SetVertices(vertices);
            m.SetIndices(indices, MeshTopology.Points, 0);

            Graphics.DrawMesh(m, Vector3.zero, Quaternion.identity, material, 0, Camera.main, 0);
        }



        //
        // Draw line segments that are not necessarily connected
        //
        
        //If they line consists of A-B-C-D, the vertices are A, B, B, C, C, D
        public static void DrawLineSegments(List<LineSegment3> lineSegments, Materials.ColorOptions color)
        {
            if (lineSegments.Count == 0)
            {
                return;
            }

            //Generate the vertices
            List<Vector3> vertices = new();

            for (int i = 0; i < lineSegments.Count; i++)
            {
                vertices.Add(lineSegments[i].p1);
                vertices.Add(lineSegments[i].p2);
            }

            //Generate the indices
            List<int> indices = new();

            for (int i = 0; i < vertices.Count; i++)
            {
                indices.Add(i);
            }

            //Generate the mesh
            Mesh m = new();

            m.SetVertices(vertices);
            m.SetIndices(indices, MeshTopology.Lines, 0);

            //Display the mesh
            Material material = Materials.GetMaterial(color);

            Graphics.DrawMesh(m, Vector3.zero, Quaternion.identity, material, 0, Camera.main, 0);
        }
    }
}

