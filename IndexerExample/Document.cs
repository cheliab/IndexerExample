using System;

namespace IndexerExample
{
    public class Document
    {
        public string Number;
        
        public MotionsCollection Motions;

        public Document()
        {
            Motions = new MotionsCollection();

            var newNumber = new Random().Next(100, 999).ToString();
            Number = newNumber;
        }
    }
}