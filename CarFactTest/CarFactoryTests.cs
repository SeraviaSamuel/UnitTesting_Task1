﻿using CarFactoryLibrary;

namespace CarFactTestLab1
{
    public class CarFactoryTests
    {
        [Fact]
        public void NewCar_CarTypeToyota_Toyota()
        {
            Car? car = CarFactory.NewCar(CarTypes.Toyota);
            Assert.IsType<Toyota>(car);
            Assert.IsNotType<BMW>(car);
        }


        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {
            Assert.Throws<NotImplementedException>(() =>
            {
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }
    }
}
