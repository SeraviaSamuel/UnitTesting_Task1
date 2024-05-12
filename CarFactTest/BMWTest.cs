using CarFactoryLibrary;

namespace CarFactTestLab1
{
    public class BMWTest
    {
        [Fact]
        public void IsStopped_velocityNot0_false()
        {

            BMW bmw = new BMW();
            bmw.velocity = 5;


            bool result = bmw.IsStopped();


            Assert.False(result);
        }
        [Fact]
        public void IsStopped_velocity0_true()
        {
            BMW bMW = new BMW();
            bMW.velocity = 0;
            bool result = bMW.IsStopped();
            Assert.True(result);
        }

        [Fact]
        public void IncreaseVelocity_valocityInRange_15_20()
        {

            BMW bMW = new BMW();
            bMW.velocity = 5;
            double AddedVelocitoy = 15;
            bMW.IncreaseVelocity(AddedVelocitoy);
            Assert.InRange(bMW.velocity, 15, 25);

        }
        [Fact]
        public void IncreaseVelocity_valocity5Add15_20()
        {

            BMW bMW = new BMW();
            bMW.velocity = 5;
            double AddedVelocitoy = 15;
            bMW.IncreaseVelocity(AddedVelocitoy);

            Assert.False(bMW.velocity < 5);
        }

        //string


        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {

            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Stopped;
            string result = bmw.GetDirection();

            Assert.Equal(DrivingMode.Stopped.ToString(), result);
        }

        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {

            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.Equal(DrivingMode.Forward.ToString(), result);

        }

        //string

        [Fact]
        public void GetDirection_DirectionForward_notContain_xx()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.DoesNotContain("xx", result);
        }

        [Fact]
        public void GetDirection_DirectionForward_F()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.StartsWith("F", result);
        }
        [Fact]
        public void GetDirection_DirectionForward_ar()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.Contains("ar", result);
        }

        [Fact]
        public void GetDirection_DirectionForward_rd()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.EndsWith("rd", result);
        }

        [Fact]
        public void GetMyCar_callMyMethod_TheSameCar()
        {

            BMW bmw1 = new BMW();
            BMW bmw2 = new BMW();
            Car car = bmw1.GetMyCar();
            Assert.Same(bmw1, car);
            Assert.NotSame(bmw2, car);
        }

    }
}
