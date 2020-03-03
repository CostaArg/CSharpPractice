namespace panini.Migrations
{
    using panini.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<panini.Models.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(panini.Models.MyDatabase context)
        {
            try
            {
                Sandwich s1 = new Sandwich()
                {
                    IdNumber = 1,
                    Cost = 6,
                    Cuisine = "Italian",
                    IsToasted = true,
                    PhotoUrl = "https://i.pinimg.com/originals/fc/d5/33/fcd533988847458144c5f04ac6fbcaa1.jpg",
                    Name = "Botrini",
                    Ingredients = Sandwich.IngredientsList.Lettuce
                };

                Sandwich s2 = new Sandwich()
                {
                    IdNumber = 2,
                    Cost = 4,
                    Cuisine = "Cuban",
                    IsToasted = true,
                    PhotoUrl = "https://www.tasteofhome.com/wp-content/uploads/2017/10/Cuban-Panini_exps107016_TH2377560A02_29_3bC_RMS-696x696.jpg",
                    Name = "Fidel Castro",
                    Ingredients = Sandwich.IngredientsList.Egg
                };

                Sandwich s3 = new Sandwich()
                {
                    IdNumber = 3,
                    Cost = 5,
                    Cuisine = "Mexican",
                    IsToasted = true,
                    PhotoUrl = "https://www.seriouseats.com/recipes/images/2013/02/20130220-mushroom-spinach-sandwich.jpg",
                    Name = "El Toastinio",
                    Ingredients = Sandwich.IngredientsList.Tomato
                };

                Sandwich s4 = new Sandwich()
                {
                    IdNumber = 4,
                    Cost = 8,
                    Cuisine = "Greek",
                    IsToasted = true,
                    PhotoUrl = "https://3.bp.blogspot.com/-i-CYMVVLiJI/UT26-w8cIkI/AAAAAAAATY8/8n6aiMZftnM/s1600/IMG_4492.JPG",
                    Name = "Feta Love",
                    Ingredients = Sandwich.IngredientsList.Cheese
                };

                Sandwich s5 = new Sandwich()
                {
                    IdNumber = 5,
                    Cost = 7,
                    Cuisine = "American",
                    IsToasted = false,
                    PhotoUrl = "https://live.staticflickr.com/3701/32874017785_2d9bffe611_b.jpg",
                    Name = "XXL BBQ",
                    Ingredients = Sandwich.IngredientsList.Bacon
                };

                context.Sandwiches.Add(s1);
                context.Sandwiches.Add(s2);
                context.Sandwiches.Add(s3);
                context.Sandwiches.Add(s4);
                context.Sandwiches.Add(s5);

                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }
    }
}
