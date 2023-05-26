using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Copypasta
{
    public class Materials
    {
        private static readonly Material matWhite;
        private static readonly Material matRed;
        private static readonly Material matBlue;
        private static readonly Material matYellow;
        private static readonly Material matGray;
        private static readonly Material matBlack;
        private static readonly Material matGreen;
        private static readonly Material matOrange;

        public enum ColorOptions
        {
            White, Red, Blue, Yellow, Gray, Black, Green, Orange
        }



        static Materials()
        {
            matWhite = GetMaterial(Color.white);

            matRed = GetMaterial(Color.red);

            matBlue = GetMaterial(Color.blue);

            matYellow = GetMaterial(Color.yellow);

            matGray = GetMaterial(Color.gray);

            matBlack = GetMaterial(Color.black);

            matGreen = GetMaterial(Color.green);

            matOrange = GetMaterial(new Color32(255, 125, 0, 255));
        }



        private static Material GetMaterial(Color color)
        {
            Material baseMaterial = new(Shader.Find("Universal Render Pipeline/Unlit"));

            baseMaterial.color = color;

            return baseMaterial;
        }



        public static Material GetMaterial(ColorOptions color)
        {
            return color switch
            {
                (ColorOptions.Red) => matRed,
                (ColorOptions.Blue) => matBlue,
                (ColorOptions.Yellow) => matYellow,
                (ColorOptions.White) => matWhite,
                (ColorOptions.Gray) => matGray,
                (ColorOptions.Black) => matBlack,
                (ColorOptions.Green) => matGreen,
                (ColorOptions.Orange) => matOrange,
                _ => matWhite,
            };
        }
    }
}