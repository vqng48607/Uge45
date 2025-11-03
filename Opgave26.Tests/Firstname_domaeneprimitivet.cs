using Xunit;
using System.Text.RegularExpressions;
using Opgave26;

namespace Firstname_domaeneprimitivet 
{
    public class Firstname_domaeneprimitivet
    {
        [Fact]
        public void LengthOfFirstname_ShouldBeWithinValidRange()
        {
            var firstname = new FirstName("John");


            Assert.InRange(firstname.GetValue().Length, 2, 20);
        }

        [Fact]
        public void CharactersInFirstname()
        {
            var firstname = new FirstName("John");

            Assert.Matches("^[A-Za-z]+$", firstname.GetValue());
        }

        [Fact]
        public void InvalidFirstnameLength_ShouldThrowException()
        {   
            string tooLongName = "ThisIsAVeryLongFirstNameExceedingLimit";

            Assert.Throws<ArgumentException>(() => new FirstName(tooLongName));
        }

        [Fact]
        public void InvalidFirstnameCharacters_ShouldThrowException()
        {
            string nameWithNumbers = "John123";

            Assert.Throws<ArgumentException>(() => new FirstName(nameWithNumbers));

        }

        [Fact]
        public void ValidFirstname_ShouldThrowException()
        {
            string name = null;

            Assert.Throws<ArgumentNullException>(() => new FirstName(name));
        }
    }
}