namespace Amazon
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }


        public string Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate();
            return rating == 0 ? "No promotion" : "Promoted to Level 1";
        }

        // this one does not need to be visible to the outside because it's only used within this class to help the Promote() methiod
        // if you change this to protected, child classes of Customer will be able to use this method but it won't be accessible outisde
        // inadvisable to use protected because if you inherit that method in child classes adn you want to change it, you risk breaking
        // the child classes
        protected int CalculateRating()
        {
            return 26;
        }
    }
}
