using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make new instance of the Cars collection
            //propbly goint to be CarsInitial Name for you 
            CarsDGipeEntities carsDGipeEntities = new CarsDGipeEntities();

            //***************************
            //List out all of the cars in the table
            //*************************

            Console.WriteLine("Print the Lis");

            foreach(Car car in carsDGipeEntities.Cars)
            {
                Console.WriteLine(car.id + " " + car.make + " " + car.model);
            }
        }
    }
}
