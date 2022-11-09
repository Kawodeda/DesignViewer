using System;
using Aurigma.Design.Math;
using NUnit.Framework;

namespace SharedTests
{
    public class Affine2DMatrixTests
    {       
        //                    1 0 0
        // IdentityMatrix  =  0 1 0
        //                    0 0 1
        public static Affine2DMatrix IdentityMatrix { get; } = new Affine2DMatrix()
        {
            M11 = 1f,
            M12 = 0f,
            M21 = 0f,
            M22 = 1f,
            D1 = 0f,
            D2 = 0f
        };

        [Test]
        public void For_ParameterlessConstructor_Expect_IdentityMatrixInitialized()
        {
            Affine2DMatrix expected = IdentityMatrix;

            // Call parameterless constructor
            var actual = new Affine2DMatrix();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticCreateIdentity_Expect_ResultIsIdentityMatrix()
        {
            Affine2DMatrix expected = IdentityMatrix;

            Affine2DMatrix actual = Affine2DMatrix.CreateIdentity();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticCreateTranslate_Expect_ResultIsTranslationByShiftMatrix()
        {
            var shift = new Point()
            {
                X = 1.43f,
                Y = -11f
            };

            //              1 0 shift.x
            // expected  =  0 1 shift.y
            //              0 0 1
            var expected = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = shift.X,
                D2 = shift.Y
            };

            Affine2DMatrix actual = Affine2DMatrix.CreateTranslate(shift);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticCreateScaleDxDy_Expect_ResultIsScaleByDxDyMatrix()
        {
            float dx = 1.5f;
            float dy = 2f;

            //              dx 0  0
            // expected  =  0  dy 0
            //              0  0  1
            var expected = new Affine2DMatrix()
            {
                M11 = dx,
                M12 = 0f,
                M21 = 0f,
                M22 = dy,
                D1 = 0f,
                D2 = 0f
            };

            Affine2DMatrix actual = Affine2DMatrix.CreateScale(dx, dy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticCreateScaleFactor_Expect_ResultIsScaleByFactorMatrix()
        {
            float scale = 0.5f;

            //              scale 0     0
            // expected  =  0     scale 0
            //              0     0     1
            var expected = new Affine2DMatrix()
            {
                M11 = scale,
                M12 = 0f,
                M21 = 0f,
                M22 = scale,
                D1 = 0f,
                D2 = 0f
            };

            Affine2DMatrix actual = Affine2DMatrix.CreateScale(scale);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StaticCreateRotate_Expect_ResultIsRotationByAngleMatrix()
        {
            // Angle in radians
            float angle = MathF.PI / 5f;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            //              cos(angle) -sin(angle) 0
            // expected  =  sin(angle)  cos(angle) 0
            //              0           0          1
            var expected = new Affine2DMatrix()
            {
                M11 = cos,
                M12 = -sin,
                M21 = sin,
                M22 = cos,
                D1 = 0f,
                D2 = 0f
            };

            Affine2DMatrix actual = Affine2DMatrix.CreateRotate(angle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_StatcMultiply_Expect_ResultIsMatrixProduct()
        {
            //             1 2 3
            // matrix1  =  4 5 6
            //             0 0 1  
            var matrix1 = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 2f,
                M21 = 4f,
                M22 = 5f,
                D1 = 3f,
                D2 = 6f
            };

            //             7  8  9
            // matrix2  =  10 11 12
            //             0  0  1  
            var matrix2 = new Affine2DMatrix()
            {
                M11 = 7f,
                M12 = 8f,
                M21 = 10f,
                M22 = 11f,
                D1 = 9f,
                D2 = 12f
            };

            //              27 30 36
            // expected  =  78 87 102
            //              0  0  1  
            var expected = new Affine2DMatrix()
            {
                M11 = 27f,
                M12 = 30f,
                M21 = 78f,
                M22 = 87f,
                D1 = 36f,
                D2 = 102f
            };

            Affine2DMatrix actual = Affine2DMatrix.Multiply(matrix1, matrix2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_Prepend_Expect_ResultIsLeftMatrixProduct()
        {
            //             2 3 4
            // matrix1  =  5 6 7
            //             0 0 1  
            var matrix1 = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 3f,
                M21 = 5f,
                M22 = 6f,
                D1 = 4f,
                D2 = 7f
            };

            //             8  9  10
            // matrix2  =  11 12 13
            //             0  0  1  
            var matrix2 = new Affine2DMatrix()
            {
                M11 = 8f,
                M12 = 9f,
                M21 = 11f,
                M22 = 12f,
                D1 = 10f,
                D2 = 13f
            };

            //              61 78  105
            // expected  =  82 105 141
            //              0  0   1  
            var expected = new Affine2DMatrix()
            {
                M11 = 61f,
                M12 = 78f,
                M21 = 82f,
                M22 = 105f,
                D1 = 105f,
                D2 = 141f
            };

            Affine2DMatrix actual = matrix1.Prepend(matrix2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_Append_Expect_ResultIsRightMatrixProduct()
        {
            //             2 3 4
            // matrix1  =  5 6 7
            //             0 0 1  
            var matrix1 = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 3f,
                M21 = 5f,
                M22 = 6f,
                D1 = 4f,
                D2 = 7f
            };

            //             8  9  10
            // matrix2  =  11 12 13
            //             0  0  1  
            var matrix2 = new Affine2DMatrix()
            {
                M11 = 8f,
                M12 = 9f,
                M21 = 11f,
                M22 = 12f,
                D1 = 10f,
                D2 = 13f
            };

            //              49  54  63
            // expected  =  106 117 135
            //              0   0   1  
            var expected = new Affine2DMatrix()
            {
                M11 = 49f,
                M12 = 54f,
                M21 = 106f,
                M22 = 117f,
                D1 = 63f,
                D2 = 135f
            };

            Affine2DMatrix actual = matrix1.Append(matrix2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_MultiplyingOperator_Expect_ResultIsEquivalentToStaticMultiply()
        {
            //             1 2 3
            // matrix1  =  4 5 6
            //             0 0 1  
            var matrix1 = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 2f,
                M21 = 4f,
                M22 = 5f,
                D1 = 3f,
                D2 = 6f
            };

            //             7  8  9
            // matrix2  =  10 11 12
            //             0  0  1  
            var matrix2 = new Affine2DMatrix()
            {
                M11 = 7f,
                M12 = 8f,
                M21 = 10f,
                M22 = 11f,
                D1 = 9f,
                D2 = 12f
            };

            Affine2DMatrix expected = Affine2DMatrix.Multiply(matrix1, matrix2);

            Affine2DMatrix actual = matrix1 * matrix2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_Translate_Expect_ResultIsMatrixTranslatedByShift()
        {
            //            1 0 5
            // matrix  =  0 1 0
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 5f,
                D2 = 0f
            };

            var shift = new Point()
            {
                X = 10f,
                Y = 20f
            };

            //              1 0 15
            // expected  =  0 1 20
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            Affine2DMatrix actual = matrix.Translate(shift);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependTranslate_Expect_TranslateTransformIsPrepended()
        {
            //            1 0 5
            // matrix  =  0 1 0
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 5f,
                D2 = 0f
            };

            var shift = new Point()
            {
                X = 10f,
                Y = 20f
            };

            //              1 0 15
            // expected  =  0 1 20
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            Affine2DMatrix actual = matrix.PrependTranslate(shift);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleDxDy_Expect_ResultIsMatrixScaledByDxDy()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float dx = 2f;
            float dy = 3f;

            //              2 0 15
            // expected  =  0 3 20
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 3f,
                D1 = 15f,
                D2 = 20f
            };

            Affine2DMatrix actual = matrix.Scale(dx, dy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependScaleDxDy_Expect_ScaleByDxDyTransformIsPrepended()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float dx = 2f;
            float dy = 3f;

            //              2 0 30
            // expected  =  0 3 60
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 3f,
                D1 = 30f,
                D2 = 60f
            };

            Affine2DMatrix actual = matrix.PrependScale(dx, dy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleFactor_Expect_ResultIsMatrixScaledByFactor()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float factor = 2f;

            //              2 0 15
            // expected  =  0 2 20
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 15f,
                D2 = 20f
            };

            Affine2DMatrix actual = matrix.Scale(factor);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependScaleFactor_Expect_ScaleByFactorTransformIsPrepended()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float factor = 2f;

            //              2 0 30
            // expected  =  0 2 40
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 30f,
                D2 = 40f
            };

            Affine2DMatrix actual = matrix.PrependScale(factor);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleAtDxDy_Expect_ResultIsMatrixScaledByDxDyRelativeToCenter()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float dx = 2f;
            float dy = 3f;
            var center = new Point()
            {
                X = 10,
                Y = 15
            };

            //              2 0 5
            // expected  =  0 3 -10
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 3f,
                D1 = 5f,
                D2 = -10f
            };

            Affine2DMatrix actual = matrix.ScaleAt(dx, dy, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_ScaleAtFactor_Expect_ResultIsMatrixScaledByFactorRelativeToCenter()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float factor = 2f;
            var center = new Point()
            {
                X = 10,
                Y = 15
            };

            //              2 0 5
            // expected  =  0 2 5
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 5f,
                D2 = 5f
            };

            Affine2DMatrix actual = matrix.ScaleAt(factor, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependScaleAtDxDy_Expect_ScaleByDxDyTransformAtCenterIsPrepended()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float dx = 2f;
            float dy = 3f;
            var center = new Point()
            {
                X = 10,
                Y = 15
            };

            //              2 0 20
            // expected  =  0 3 30
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 3f,
                D1 = 20f,
                D2 = 30f
            };

            Affine2DMatrix actual = matrix.PrependScaleAt(dx, dy, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependScaleAtFactor_Expect_ScaleByFactorTransformAtCenterIsPrepended()
        {
            //            1 0 15
            // matrix  =  0 1 20
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 1f,
                M12 = 0f,
                M21 = 0f,
                M22 = 1f,
                D1 = 15f,
                D2 = 20f
            };

            float factor = 2f;
            var center = new Point()
            {
                X = 10,
                Y = 15
            };

            //              2 0 20
            // expected  =  0 2 25
            //              0 0 1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 20f,
                D2 = 25f
            };

            Affine2DMatrix actual = matrix.PrependScaleAt(factor, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_Rotate_Expect_ResultIsMatrixRotatedByAngle()
        {
            float angle = MathF.PI / 6f;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            //            2 0 20
            // matrix  =  0 2 25
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 20f,
                D2 = 25f
            };

            //              2cos -2sin 20
            // expected  =  2sin 2cos  25
            //              0    0     1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f * cos,
                M12 = -2f * sin,
                M21 = 2f * sin,
                M22 = 2f * cos,
                D1 = 20f,
                D2 = 25f
            };

            Affine2DMatrix actual = matrix.Rotate(angle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependRotate_Expect_RotateByAngleTransformIsPrepended()
        {
            float angle = MathF.PI / 6f;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            //            2 0 20
            // matrix  =  0 2 25
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 20f,
                D2 = 25f
            };

            //              2cos -2sin 20cos - 25sin
            // expected  =  2sin 2cos  20sin + 25cos
            //              0    0     1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f * cos,
                M12 = -2f * sin,
                M21 = 2f * sin,
                M22 = 2f * cos,
                D1 = 20f * cos - 25f * sin,
                D2 = 20f * sin + 25f * cos
            };

            Affine2DMatrix actual = matrix.PrependRotate(angle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_RotateAt_Expect_ResultIsMatrixRotatedByAngleRelativeToCenter()
        {
            float angle = MathF.PI / 6f;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            //            2 0 20
            // matrix  =  0 2 25
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 20f,
                D2 = 25f
            };

            var center = new Point()
            {
                X = 10,
                Y = 15
            };

            //              2cos -2sin -20cos + 30sin + 40
            // expected  =  2sin 2cos  -20sin - 30cos + 55
            //              0    0     1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f * cos,
                M12 = -2f * sin,
                M21 = 2f * sin,
                M22 = 2f * cos,
                D1 = -20f * cos + 30f * sin + 40f,
                D2 = -20f * sin - 30f * cos + 55f
            };

            Affine2DMatrix actual = matrix.RotateAt(angle, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_PrependRotateAt_Expect_RotateByAngleAtCenterTransformIsPrepended()
        {
            float angle = MathF.PI / 6f;
            float sin = MathF.Sin(angle);
            float cos = MathF.Cos(angle);

            //            2 0 20
            // matrix  =  0 2 25
            //            0 0 1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 2f,
                M12 = 0f,
                M21 = 0f,
                M22 = 2f,
                D1 = 20f,
                D2 = 25f
            };

            var center = new Point()
            {
                X = 10,
                Y = 15
            };

            //              2cos -2sin 10cos - 10sin + 10
            // expected  =  2sin 2cos  10sin + 10cos + 15
            //              0    0     1 
            var expected = new Affine2DMatrix()
            {
                M11 = 2f * cos,
                M12 = -2f * sin,
                M21 = 2f * sin,
                M22 = 2f * cos,
                D1 = 10f * cos - 10f * sin + 10f,
                D2 = 10f * sin + 10f * cos + 15f
            };

            Affine2DMatrix actual = matrix.PrependRotateAt(angle, center);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_GetDeterminant_Expect_ResultIsMatrixDeterminant()
        {
            //            14 -14 15
            // matrix  =  9   10 20
            //            0   0  1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 14f,
                M12 = -14f,
                M21 = 9f,
                M22 = 10f,
                D1 = 15f,
                D2 = 20f
            };

            float expected = 266f;

            float actual = matrix.GetDeterminant();

            float epsilon = 0.00001f;
            Assert.IsTrue(expected.NearlyEquals(actual, epsilon));
        }

        [Test]
        public void For_Inverse_Expect_ResultIsInverseMatrix()
        {
            //            14 -14 15
            // matrix  =  9   10 20
            //            0   0  1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 14f,
                M12 = -14f,
                M21 = 9f,
                M22 = 10f,
                D1 = 15f,
                D2 = 20f
            };

            //              5/133  1/19  (-82/133 - 1)
            // expected  = -9/266  1/19 -145/266
            //              0      0     1
            var expected = new Affine2DMatrix()
            {
                M11 = 5f / 133f,
                M12 = 1f / 19f,
                M21 = -9f / 266f,
                M22 = 1f / 19f,
                D1 = -1f - 82f / 133f,
                D2 = -145f / 266f
            };

            Affine2DMatrix actual = matrix.Inverse();

            float epsilon = 0.00001f;
            Assert.IsTrue(expected.NearlyEquals(actual, epsilon));
        }

        [Test]
        public void When_MultiplyInverseMatrixByInitialMatrix_Expect_ResultIsIdentityMatrix()
        {
            //            14 -14 15
            // matrix  =  9   10 20
            //            0   0  1  
            var matrix = new Affine2DMatrix()
            {
                M11 = 14f,
                M12 = -14f,
                M21 = 9f,
                M22 = 10f,
                D1 = 15f,
                D2 = 20f
            };

            Affine2DMatrix inverse = matrix.Inverse();

            Affine2DMatrix actual = matrix * inverse;

            Affine2DMatrix expected = Affine2DMatrix.CreateIdentity();

            float epsilon = 0.00001f;
            Assert.IsTrue(expected.NearlyEquals(actual, epsilon));
        }

        [Test]
        public void When_UseNearlyEqualsWithNegativeEpsilon_Expect_ArgumentExceptionIsThrown()
        {
            //             14 -14 15
            // matrix1  =  9   10 20
            //             0   0  1  
            var matrix1 = new Affine2DMatrix()
            {
                M11 = 14f,
                M12 = -14f,
                M21 = 9f,
                M22 = 10f,
                D1 = 15f,
                D2 = 20f
            };

            //             14 -14 15
            // matrix2  =  9  ~10 20
            //             0   0  1  
            var matrix2 = new Affine2DMatrix()
            {
                M11 = 14f,
                M12 = -14f,
                M21 = 9f,
                M22 = 9.999999f,
                D1 = 15f,
                D2 = 20f
            };

            float epsilon = -0.00001f;

            Assert.Throws<ArgumentException>(
                () => matrix1.NearlyEquals(matrix2, epsilon));
        }
    }
}