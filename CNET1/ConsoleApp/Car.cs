namespace CarRental
{
    class Car
    {
        public Car(string regNumber)
        {
            RegNumber = regNumber;
        }

        public Car(string regNumber, CarBrand brand, int year)
        {
            RegNumber = regNumber;
            Brand = brand;
            ModelYear = year;
        }
        public string RegNumber { get; }

        public CarBrand Brand { get; set; }

        public int ModelYear { get; set; }

        public string CarInfo()
        {
            return $"auto, spz: {RegNumber}, rok výroby: {ModelYear}, značka: {Brand}";
        }
    }

    enum CarBrand
    {
        SKODA,
        AUDI,
        FIAT,
        KIA,
        BMW,
    }
}
