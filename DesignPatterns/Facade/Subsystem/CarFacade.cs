using System;

namespace Facade.Subsystem
{
    public class CarFacade
    {
        private readonly CarAccessories accessories;
        private readonly CarBody body;
        private readonly CarEngine engine;
        private readonly CarModel model;
        public CarFacade()
        {
            accessories = new CarAccessories();
            body = new CarBody();
            engine = new CarEngine();
            model = new CarModel();
        }
        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();
            Console.WriteLine("******** Car creation is completed. **********");
        }
    }
}
