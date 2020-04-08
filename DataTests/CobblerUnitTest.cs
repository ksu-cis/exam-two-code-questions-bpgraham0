using System;
using ExamTwoCodeQuestions.Data;
using Xunit;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.DataTests
{
    public class CobblerUnitTests
    {
        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void CobblerImplementsPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cobbler);
        }

        /// <summary>
        /// checks if change in fruit invokes propertychanged for fruit
        /// </summary>
        [Fact]
        public void ChangingFruitPropertyShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => {
                cobbler.Fruit = FruitFilling.Blueberry;
            });
        }

        /// <summary>
        /// checks if change in fruit invokes propertychanged for fruit
        /// </summary>
        [Fact]
        public void ChangingisCherryPropertyShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => {
                cobbler.isCherry = true;
            });
        }

        /// <summary>
        /// checks if change in fruit invokes propertychanged for fruit
        /// </summary>
        [Fact]
        public void ChangingisPeachPropertyShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => {
                cobbler.isPeach = true;
            });
        }

        /// <summary>
        /// checks if change in fruit invokes propertychanged for fruit
        /// </summary>
        [Fact]
        public void ChangingisBlueberryPropertyShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => {
                cobbler.isBlueberry = true;
            });
        }

        /// <summary>
        /// checks if change in withicecream invokes propertychanged for WithIceCream
        /// </summary>
        [Fact]
        public void ChangingWithIceCreamPropertyShouldInvokePropertyChangedForWithIceCream()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "WithIceCream", () => {
                cobbler.WithIceCream = false;
            });
        }

        /// <summary>
        /// checks if change in WithIceCrem invokes propertychanged for SpecialInstrctions
        /// </summary>
        [Fact]
        public void ChangingWithIceCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "SpecialInstructions", () => {
                cobbler.WithIceCream = false;
            });
        }

        /// <summary>
        /// checks if change in WithIceCream invokes propertychanged for Price
        /// </summary>
        [Fact]
        public void ChangingWithIceCreamPropertyShouldInvokePropertyChangedForPrice()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Price", () => {
                cobbler.WithIceCream = false;
            });
        }

        [Theory]
        [InlineData(FruitFilling.Cherry)]
        [InlineData(FruitFilling.Blueberry)]
        [InlineData(FruitFilling.Peach)]
        public void ShouldBeAbleToSetFruit(FruitFilling fruit)
        {
            var cobbler = new Cobbler();
            cobbler.Fruit = fruit;
            Assert.Equal(fruit, cobbler.Fruit);
        }

        [Fact]
        public void ShouldBeServedWithIceCreamByDefault()
        {
            var cobbler = new Cobbler();
            Assert.True(cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetWithIceCream(bool serveWithIceCream)
        {
            var cobbler = new Cobbler();
            cobbler.WithIceCream = serveWithIceCream;
            Assert.Equal(serveWithIceCream, cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true, 5.32)]
        [InlineData(false, 4.25)]
        public void PriceShouldReflectIceCream(bool serveWithIceCream, double price)
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = serveWithIceCream
            };
            Assert.Equal(price, cobbler.Price);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var cobbler = new Cobbler();
            Assert.Empty(cobbler.SpecialInstructions);
        }

        [Fact]
        public void SpecialIstructionsShouldSpecifyHoldIceCream()
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = false
            };
            Assert.Collection<string>(cobbler.SpecialInstructions, instruction =>
            {
                Assert.Equal("Hold Ice Cream", instruction);
            });
        }

        [Fact]
        public void ShouldImplementIOrderItemInterface()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<IOrderItem>(cobbler);
        }


    }
}
