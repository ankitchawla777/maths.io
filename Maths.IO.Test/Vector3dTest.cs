using Maths.IO;
using NUnit.Framework;

namespace Tests
{
    public class Vector3dTest
    {

        [Test]
        public void VectorAdditionTest()
        {
            var v1 = new Vector3d(1, 1, 1);
            var v2 = new Vector3d(1, 1, 1);
            var v3 = v1 + v2;
            System.Diagnostics.Debug.WriteLine(v3);
            Assert.True(v3.X == 2 && v3.Y == 2 && v3.Z == 2);
        }
        [Test]
        public void VectorScalarProductTest()
        {
            var v1 = new Vector3d(1, 1, 1);
            var v3 = v1 * 2;
            System.Diagnostics.Debug.WriteLine(v3);
            Assert.True(v3.X == 2 && v3.Y == 2 && v3.Z == 2);
        }
    }
}