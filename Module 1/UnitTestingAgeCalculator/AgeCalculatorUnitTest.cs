using System;
using Xunit;
using FirstResponsiveWebAppCluney.Models;

namespace UnitTestingAgeCalculator
{
    public class AgeCalculatorUnitTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            ResponsiveModel RM = new ResponsiveModel();
            RM.Name = "Trever Cluney";
            RM.BirthYear = new System.DateTime(1995, 5, 11);
            string expected = "Trever Cluney will be 27 years old by December 31st of 2022";
            string actual;
            //act
            actual = RM.AgeThisYear();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            ResponsiveModel RM = new ResponsiveModel();
            RM.Name = "Johnny Bravo";
            RM.BirthYear = new System.DateTime(1977, 7, 14);
            string expected = "Johnny Bravo will be 45 years old by December 31st of 2022";
            string actual;
            //act
            actual = RM.AgeThisYear();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            //arrange
            ResponsiveModel RM = new ResponsiveModel();
            RM.Name = "Komi Shouko";
            RM.BirthYear = new System.DateTime(2001, 12, 25);
            string expected = "Komi Shouko will be 21 years old by December 31st of 2022";
            string actual;
            //act
            actual = RM.AgeThisYear();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            //arrange
            ResponsiveModel RM = new ResponsiveModel();
            RM.Name = "Hubert Farnsworth";
            RM.BirthYear = new System.DateTime(2841, 4, 9);
            string expected = "Hubert Farnsworth will be -819 years old by December 31st of 2022";
            string actual;
            //act
            actual = RM.AgeThisYear();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
