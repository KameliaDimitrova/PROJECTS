using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ingredients = int.Parse(Console.ReadLine());
            var TotalCalories = 0;

            for (int i = 0; i<Ingredients;i++)
            {
                string addIngredients = Console.ReadLine();
                addIngredients = addIngredients.ToUpper();


                switch (addIngredients)
                {
                    case "CHEESE":
                        TotalCalories = TotalCalories + 500;
                        break;
                    case "TOMATO SAUCE":
                        TotalCalories = TotalCalories + 150;
                        break;
                    case "SALAMI":
                        TotalCalories = TotalCalories + 600;
                        break;
                    case "PEPPER":
                        TotalCalories = TotalCalories + 50;
                        break;

                    default: break;
                }
            }
            Console.WriteLine($"Total calories: {TotalCalories}");


            }
        }
    }

