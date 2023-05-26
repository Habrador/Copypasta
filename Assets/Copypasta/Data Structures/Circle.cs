using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Copypasta
{
    public struct Circle
    {
        public Vector3 center;

        public float radius;

        public Circle(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }
}