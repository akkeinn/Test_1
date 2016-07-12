using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area;

namespace Area_Triangle_Test
{
    [TestClass]
    public class Area_Triangle_Test
    {
        //Тест Проверки корректности введенных сторон 
        [TestMethod]
        public void AreaTriangle_WhenSidesLessThanZero_ShouldThrowUserExceptionAndWrongSidesMessage()
        {
            //arrange
            double side1 = 10.1;
            double side2 = 0.1;
            double side3 = -12.0091;
            double Area = 0;

            //act
            try
            {
                Area = Area_Triangle.area_right_triangle(side1, side2, side3);
            }
            catch (userExeption Excp)
            {
                //assert
                StringAssert.Contains(Excp.Message, Area_Triangle.Area_right_Triangle_SidesLessThanZero);
                return;
            }

            Assert.Fail("Исключение не произошло! Введенные начальные значения не проверяют условие \"Не корректные значения сторон\".");

        }


        //Тест Проверки условия прямоугольности 
        [TestMethod]
        public void AreaTriangle_WhenTriangleIsNotRight_ShouldThrowUserExceptionAndWrongTriangleMessage()
        {
            //arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 15;
            double Area = 0;

            //act
            try
            {
                Area = Area_Triangle.area_right_triangle(side1, side2, side3);
            }
            catch (userExeption Excp)
            {
            //assert
                StringAssert.Contains(Excp.Message, Area_Triangle.Area_right_Triangle_TriangleIsNotRight);
                return;
            }

            Assert.Fail("Исключение не произошло! Введенные начальные значения не проверяют условие \"Треугольник не Прямоугольный \".");

        }


        //Тест Расчета площади 
        [TestMethod]
        public void AreaTriangle_ValidSides_AreaOfRightTriangle()
        {
            //arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expexted_Area = 6;
            double actual_Area = 0;

            //act
                actual_Area = Area_Triangle.area_right_triangle(side1, side2, side3);
            
            Assert.AreEqual(actual_Area,expexted_Area,0.001,"Площадь рассчитана неверно!");

        }
        


    }
}
