using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    public class Car
    {
        public string brand;
        public int year;
        public string color;            //declaring variables,fields
        public Car(string carBrand,string carColor,int carYear)  //created car constructor with multiple parameters
        {
           brand=carBrand;
            year = carYear;
            color = carColor;


        }

    }
}
