namespace Builder
{
    internal class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder() : base(new Vehicle("Scooter")) { }
        public override void BuildFrame() => Vehicle["frame"] = "Scooter Frame";
        public override void BuildEngine() =>Vehicle["engine"] = "50 cc";
        public override void BuildWheels() => Vehicle["wheels"] = "2";
        public override void BuildDoors() => Vehicle["doors"] = "4";
    }
}
