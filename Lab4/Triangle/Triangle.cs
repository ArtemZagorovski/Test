using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTests
{
    public static class TriangleTest
    {
        public static bool IsTriangle(double A, double B, double C)
        {
            if ((A < 0 || B < 0 || C < 0) && (B + C > A) || (A + C > B) || (A + B > C))
                return false;
            else return true;
        }
    }
}
