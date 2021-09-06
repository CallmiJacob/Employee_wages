namespace class123
{
    class car
    {
        string colour = "red";
        string model = "swift";

        static void main(string[] args)
        {
            car myObj = new car();
            console.writeline(myObj.colour);
        }

        public void Drive()
        {
            console.writeline(@Driving);
        }
    
    }

}