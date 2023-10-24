using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radijvektori
{
    internal interface INorma
    {
        double Norma {  get; }
        void Normiraj();
    }
    internal /* ref readonly */ struct Radijvektor : INorma
    {
        public double Norma => Duljina;
        public void Normiraj()
        {
            double n = Norma;
            if(n != 0)
            {
                X /= n; Y /= n; Z /= n;
            }
        }
        public /* readonly */ double X, Y, Z;
        public readonly double Duljina
        {
            get { /* X = 5; */  return Math.Sqrt(X * X + Y * Y + Z * Z);}
        }
        public override string ToString()
            => "(" + X + ", " + Y + ", " + Z + ")";
        public Radijvektor(double x, double y = 0, double z = 0)
        {
            X = x; Y = y; Z = z;
        }
        public Radijvektor() : this(1) { }
        public static Radijvektor operator + (Radijvektor a,  Radijvektor b)
        {
            return new Radijvektor(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        public static Radijvektor operator * (double k, Radijvektor a)
        {
            return new Radijvektor(k * a.X, k * a.Y, k * a.Z);
        }
        public static Radijvektor operator -(Radijvektor a, Radijvektor b)
            => a + (-1) * b;
    }
}
