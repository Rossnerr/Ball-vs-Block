﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP_Lab._5
{
    public class Object
    {
        public static int count = 0;

        public float CenterX { get; set; }
        public float CenterY { get; set; }

        public int Id { get; set; }
        
        public float DimensionX { get; set; }
        public float DimensionY { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public float MoveX { get; set; }
        public float MoveY { get; set; }

        public SolidBrush brush { get; set; }

        public Object(float positonX, float positionY, float moveX, float moveY, float dimensionX, float dimensionY)
        {
            count++;
            Id = count;

            PositionX = positonX;
            PositionY = positionY;

            MoveX = moveX;
            MoveY = moveY;

            DimensionX = dimensionX;
            DimensionY = dimensionY;

            CenterX = PositionX + DimensionX / 2;
            CenterY = PositionX + DimensionY / 2;

            brush = new SolidBrush(Color.Red);
        }

        public void MoveObject()
        {
            PositionX += MoveX;
            PositionY += MoveY;

            CenterX = PositionX + DimensionX / 2;
            CenterY = PositionY + DimensionY / 2;
        }

        public void ChangeColor()
        {
            this.brush.Color = this.brush.Color == Color.Red ? this.brush.Color = Color.Blue : this.brush.Color = Color.Red;
        }
    }
}
