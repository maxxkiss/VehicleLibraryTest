namespace VehicleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMove()
        {
            // arrange
            var engine = new DieselEngine(2, 6, 180);
            var wheels = new[]
            {
                new Wheel("Continental"),
                new Wheel("Continental"),
                new Wheel("Goodyear"),
                new Wheel("Goodyear"),
            };
            var carrier = new Suspension(wheels, engine);
            var car = new Car("Ford", "F-150", engine, carrier);
            // act
            var result = car.Move();
            // assert
            Assert.AreEqual(result, "Vroom");
        }

        [TestMethod]
        public void TestBrakeStandingStill()
        {
            // arrange
            var engine = new DieselEngine(2, 6, 180);
            var wheels = new[]
            {
                new Wheel("Continental"),
                new Wheel("Continental"),
                new Wheel("Goodyear"),
                new Wheel("Goodyear"),
            };
            var carrier = new Suspension(wheels, engine);
            var car = new Car("Ford", "F-150", engine, carrier);
            // act
            var result = car.Stop();
            // assert
            Assert.AreEqual(result, "...");
        }

        [TestMethod]
        public void TestBrakeInMotion()
        {
            // arrange
            var engine = new ElectricEngine(350);
            var props = new[]
            {
                new Propeller("HighFly"),
                new Propeller("HighFly"),
            };
            var carrier = new Axis(props, engine);
            var copter = new Car("Boeing", "CH-47", engine, carrier);
            // act
            copter.Move();
            var result = copter.Stop();
            // assert
            Assert.AreEqual(result, "Foof");
        }

        [TestMethod]
        public void TestBrakeInHighSpeedMotion()
        {
            // arrange
            var engine = new DieselEngine(2, 6, 180);
            var wheels = new[]
            {
                new Wheel("Continental"),
                new Wheel("Continental"),
                new Wheel("Goodyear"),
                new Wheel("Goodyear"),
            };
            var carrier = new Suspension(wheels, engine);
            var car = new Car("Ford", "F-150", engine, carrier);
            // act
            car.Move();
            car.Move();
            car.Move();
            var result = car.Stop();
            // assert
            Assert.AreEqual(result, "ShhhShhhShhh");
        }

        [TestMethod]
        public void TestBrakeWithoutMovingParts()
        {
            // arrange
            var engine = new DieselEngine(2, 6, 180);
            var wheels = new Wheel[0];
            var carrier = new Suspension(wheels, engine);
            var car = new Car("Ford", "F-150", engine, carrier);
            // act
            car.Move();
            var result = car.Stop();
            // assert
            Assert.AreEqual(result, "...");
        }
    }
}