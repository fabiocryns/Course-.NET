﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer.Internals {
    public class Vector {
        public double X;
        public double Y;
        public double Z;

        public Vector(double x, double y, double z) { X = x; Y = y; Z = z; }
        public Vector(string str) {
            string[] nums = str.Split(',');
            if (nums.Length != 3) throw new ArgumentException();
            CultureInfo formatProvider = new CultureInfo("en-US");
            X = double.Parse(nums[0], formatProvider);
            Y = double.Parse(nums[1], formatProvider);
            Z = double.Parse(nums[2], formatProvider);
        }
        public static Vector Make(double x, double y, double z) { return new Vector(x, y, z); }
        public static Vector Times(double n, Vector v) {
            return new Vector(v.X * n, v.Y * n, v.Z * n);
        }
        //public static Vector Minus(Vector v1, Vector v2) {
        //    return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        //}
        //public static Vector Plus(Vector v1, Vector v2) {
        //    return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        //}
        public static double Dot(Vector v1, Vector v2) {
            return (v1.X * v2.X) + (v1.Y * v2.Y) + (v1.Z * v2.Z);
        }
        public static double Mag(Vector v) { return Math.Sqrt(Dot(v, v)); }
        public static Vector Norm(Vector v) {
            double mag = Mag(v);
            double div = mag == 0 ? double.PositiveInfinity : 1 / mag;
            return Times(div, v);
        }
        public static Vector Cross(Vector v1, Vector v2) {
            return new Vector(((v1.Y * v2.Z) - (v1.Z * v2.Y)),
                              ((v1.Z * v2.X) - (v1.X * v2.Z)),
                              ((v1.X * v2.Y) - (v1.Y * v2.X)));
        }
        public static bool Equals(Vector v1, Vector v2) {
            return (v1.X == v2.X) && (v1.Y == v2.Y) && (v1.Z == v2.Z);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    }
}
