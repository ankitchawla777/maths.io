
using System;

namespace Maths.IO
{
    /// <summary>
    /// 3 Dimensional Vector
    /// </summary>
    public class Vector3d
    {
        private readonly int[] vector = new int[3];
        public Vector3d(int x, int y, int z)
        {
            vector[0] = x;
            vector[1] = y;
            vector[2] = z;
        }
        /// <summary>
        /// X Coordinate
        /// </summary>
        public int X { get { return vector[0]; } }

        /// <summary>
        /// Y Coordinate
        /// </summary>
        public int Y { get { return vector[1]; } }

        /// <summary>
        /// Z Coordinate
        /// </summary>
        public int Z { get { return vector[2]; } }

        /// <summary>
        /// Vector Addition
        /// </summary>
        /// <param name="vector1">Vector 1</param>
        /// <param name="vector2">Vector 2</param>
        /// <returns><see cref="Vector3d"/></returns>
        public static Vector3d operator +(Vector3d vector1, Vector3d vector2)
        {
            var x = vector1.X + vector2.X;
            var y = vector1.Y + vector2.Y;
            var z = vector1.Z + vector2.Z;
            return new Vector3d(x, y, z);
        }
        /// <summary>
        /// Vector Subtraction
        /// </summary>
        /// <param name="vector1">Vector 1</param>
        /// <param name="vector2">Vector 2</param>
        /// <returns><see cref="Vector3d"/></returns>
        public static Vector3d operator -(Vector3d vector1, Vector3d vector2)
        {
            var x = vector1.X - vector2.X;
            var y = vector1.Y - vector2.Y;
            var z = vector1.Z - vector2.Z;
            return new Vector3d(x, y, z);
        }

        /// <summary>
        ///  Vector Scaler Multiplication
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="scaler"></param>
        /// <returns></returns>
        public static Vector3d operator *(Vector3d vector1, int scaler)
        {
            var x = vector1.X * scaler;
            var y = vector1.Y * scaler;
            var z = vector1.Z * scaler;
            return new Vector3d(x, y, z);
        }

        /// <summary>
        /// Vector Cross Product
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector3d operator *(Vector3d vector1, Vector3d vector2)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Vector Dot Product
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector3d operator %(Vector3d vector1, Vector3d vector2)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{X}i + {Y}j + {Z}k";
        }
    }
}
