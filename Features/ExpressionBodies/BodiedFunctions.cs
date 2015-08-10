using System;
namespace Features.ExpressionBodies
{
    public class BodiedFunctions
    {
        private string heldName;
        public DateTime InitalDate { get; }
        //Get for a property with a expression as part of the getter declaration
        public DateTime FiveDaysLater => InitalDate.AddDays(5);
        
        public BodiedFunctions(DateTime date, string name)
        {
            //reuse of an AutoProperty initialiser!
            InitalDate = date;
            heldName = name;
        }

        /*
        * Two points here, fisrtly a reuse of the new string interpolation. Next is the () in the name which
        * marks this as a method instead of a bodied getter.
        */
        public string GetNameInMessage() => $"Welcome {heldName}. Have a nice day!";
    }
}