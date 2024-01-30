namespace RecipeSystem
{
    class Ingredient
    {
        public double Quantity;
        public string Name;
        public string UnitMeasurement;
        public Ingredient(string Name, double Quantity, string UnitMeasurement) 
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.UnitMeasurement = UnitMeasurement; 
        }
    }
}
