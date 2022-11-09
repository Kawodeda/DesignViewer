using System;
using Aurigma.Design.Math;
using NUnit.Framework;

namespace SharedTests
{
    public class PointTests
    {
        [Test]
        public void For_ConstructorXY_Expect_XYPropertiesInitialized()
        {
            float x = 20f;
            float y = 30f;

            var expected = new Point()
            {
                X = x,
                Y = y
            };

            var actual = new Point(x, y);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticMultiply_Expect_ResultIsMatrixProduct()
        {
            var point = new Point()
            {
                X = 10f,
                Y = 15f
            };

            //            2 0 10
            // matrix  =  0 2 5
            //            0 0 1
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 10f,
                D2 = 5f
            };

            var expected = new Point()
            {
                X = 30f,
                Y = 35f
            };

            Point actual = Point.Multiply(matrix, point);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticMultiply_Expect_OperationIsCommutative()
        {
            var point = new Point()
            {
                X = 10f,
                Y = 15f
            };

            //            2 0 10
            // matrix  =  0 2 5
            //            0 0 1
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 10f,
                D2 = 5f
            };

            Point product1 = Point.Multiply(matrix, point);
            Point product2 = Point.Multiply(point, matrix);

            Assert.AreEqual(product1, product2);
        }

        [Test]
        public void For_MultiplyBy_Expect_ResultIsEquivalentToStaticMultiply()
        {
            var point = new Point()
            {
                X = 10f,
                Y = 15f
            };

            //            2 0 10
            // matrix  =  0 2 5
            //            0 0 1
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 10f,
                D2 = 5f
            };

            Point expected = Point.Multiply(point, matrix);

            Point actual = point.MultiplyBy(matrix);
            

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_MultiplyingOperator_Expect_ResultIsEquivalentToStaticMultiply()
        {
            var point = new Point()
            {
                X = 10f,
                Y = 15f
            };

            //            2 0 10
            // matrix  =  0 2 5
            //            0 0 1
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 10f,
                D2 = 5f
            };

            Point expected = Point.Multiply(point, matrix);

            Point actual = point * matrix;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_MultiplyingOperator_Expect_OperationIsCommutative()
        {
            var point = new Point()
            {
                X = 10f,
                Y = 15f
            };

            //            2 0 10
            // matrix  =  0 2 5
            //            0 0 1
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 10f,
                D2 = 5f
            };

            Point product1 = matrix * point;
            Point product2 = point * matrix;

            Assert.AreEqual(product1, product2);
        }

        [Test]
        public void For_StaticNegate_Expect_ResultIsPointWithNegatedCoordinates()
        {
            var point = new Point()
            {
                X = 10f,
                Y = -15f
            };

            var expected = new Point()
            {
                X = -10f,
                Y = 15f
            };

            Point actual = Point.Negate(point);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_UnaryMinusOperator_Expect_ResultIsEquivalentToStaticNegate()
        {
            var point = new Point()
            {
                X = 10f,
                Y = -15f
            };

            var expected = Point.Negate(point);

            Point actual = -point;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_Translate_Expect_ResultIsPointTranslatedByShift()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 10f
            };

            var shift = new Point()
            {
                X = 10f,
                Y = 5f
            };

            var expected = new Point()
            {
                X = 14f,
                Y = 15f
            };

            Point actual = point.Translate(shift);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleDxDy_Expect_ResultIsPointScaledByDxDy()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 10f
            };

            float dx = 2f;
            float dy = 3f;

            var expected = new Point()
            {
                X = 8f,
                Y = 30f
            };

            Point actual = point.Scale(dx, dy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleFactor_Expect_ResultIsPointScaledByFactor()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 10f
            };

            float factor = 2f;

            var expected = new Point()
            {
                X = 8f,
                Y = 20f
            };

            Point actual = point.Scale(factor);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleAtDxDy_Expect_ResultIsPointScaledByDxDyRelativeToCenter()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 10f
            };

            var center = new Point()
            {
                X = 10f,
                Y = 5f
            };

            float dx = 2f;
            float dy = 3f;

            var expected = new Point()
            {
                X = -2f,
                Y = 20f
            };

            Point actual = point.ScaleAt(dx, dy, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleAtFactor_Expect_ResultIsPointScaledByFactorRelativeToCenter()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 10f
            };

            var center = new Point()
            {
                X = 10f,
                Y = 5f
            };

            float factor = 2f;

            var expected = new Point()
            {
                X = -2f,
                Y = 15f
            };

            Point actual = point.ScaleAt(factor, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_Rotate_Expect_ResultIsPointRotatedByAngle()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 0f
            };

            float angle = MathF.PI / 2;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            var expected = new Point()
            {
                X = point.X * cos - point.Y * sin,
                Y = point.X * sin + point.Y * cos
            };

            Point actual = point.Rotate(angle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_RotateAt_Expect_ResultIsPointRotatedByAngleRelativeToCenter()
        {
            var point = new Point()
            {
                X = 4f,
                Y = 0f
            };

            var center = new Point()
            {
                X = 2f,
                Y = 2f
            };

            float angle = MathF.PI / 2;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            var expected = new Point()
            {
                X = point.X * cos - point.Y * sin - 2 * cos + 2 * sin + 2,
                Y = point.X * sin + point.Y * cos - 2 * sin - 2 * cos + 2
            };

            Point actual = point.RotateAt(angle, center);

            float epsilon = 0.000001f;

            // Doesn't work without NearlyEquals
            Assert.IsTrue(expected.NearlyEquals(actual, epsilon));
        }

        [Test]
        public void When_UseNearlyEqualsWithNegativeEpsilon_Expect_ArgumentExceptionIsThrown()
        {
            var point1 = new Point()
            {
                X = 1.19999998f,
                Y = 0f
            };

            var point2 = new Point()
            {
                X = 1.2f,
                Y = 0f
            };

            float epsilon = -0.00001f;

            try
            {
                point1.NearlyEquals(point2, epsilon);
                Assert.Fail();
            }
            catch(ArgumentException)
            {
                Assert.Pass();
            }
        }
    }
}
