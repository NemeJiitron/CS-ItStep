using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw14
{
    public enum Animals
    {
        dog = 1,
        cat,
        bird
    }
    internal class AnimalAttribute : Attribute
    {
        private Animals pet;
        public Animals Pet { get { return pet; } }
        public AnimalAttribute(Animals animal) 
        {
            pet = animal;
        }
    }
    public class CustomAttrDemo
    {
        [AnimalAttribute(Animals.dog)]
        public void DogMethod()
        {

        }
        [AnimalAttribute(Animals.cat)]
        public void CatMethod()
        {

        }
        [AnimalAttribute(Animals.bird)]
        public void BirdMethod()
        {

        }
    }

}
