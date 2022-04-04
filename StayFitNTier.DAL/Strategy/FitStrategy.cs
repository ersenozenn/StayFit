using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.Strategy
{
    public class FitStrategy:CreateDatabaseIfNotExists<StayFitDbContext>
    {
        protected override void Seed(StayFitDbContext context)
        {
            Category category1 = new Category
            {
                Name = "Ready-Made Meals"
            };
            Category category2 = new Category
            {
                Name = "Meat"
            };
            Category category3 = new Category
            {
                Name = "Seeds, nuts and spices"
            };
            Category category4 = new Category
            {
                Name = "Sweets and snacks"
            };
            Category category5 = new Category
            {
                Name = "Mushrooms"
            };
            Category category6 = new Category
            {
                Name = "Dairy"
            };
            Category category7 = new Category
            {
                Name = "Bread"
            };
            Category category8 = new Category
            {
                Name = "Fats"
            };
            Category category9 = new Category
            {
                Name = "Pasta and bulk products"
            };
            Category category10 = new Category
            {
                Name = "Drinks"
            };
            Category category11 = new Category
            {
                Name = "Fish and seafood"
            };
            Category category12 = new Category
            {
                Name = "Vegetable and fruit"
            };


            SubCategory subCategory1 = new SubCategory
            {
                CategoryId = 1,
                Name = "Extras"
            };
            SubCategory subCategory2 = new SubCategory
            {
                CategoryId = 1,
                Name = "Vegetable dishes"
            };
            SubCategory subCategory3 = new SubCategory
            {
                CategoryId = 1,
                Name = "Fish and seafood dishes"
            };
            SubCategory subCategory4 = new SubCategory
            {
                CategoryId = 1,
                Name = "Fastfood"
            };
            SubCategory subCategory5 = new SubCategory
            {
                CategoryId = 1,
                Name = "Meat and vegetable"
            };
            SubCategory subCategory6 = new SubCategory
            {
                CategoryId = 1,
                Name = "Soups"
            };
            SubCategory subCategory7 = new SubCategory
            {
                CategoryId = 1,
                Name = "Meat dishes"
            };
            SubCategory subCategory8 = new SubCategory
            {
                CategoryId = 1,
                Name = "Egg dishes"
            };
            SubCategory subCategory9 = new SubCategory
            {
                CategoryId = 2,
                Name = "Mutton"
            };
            SubCategory subCategory10 = new SubCategory
            {
                CategoryId = 2,
                Name = "Lamb,veal"
            };
            SubCategory subCategory11 = new SubCategory
            {
                CategoryId = 2,
                Name = "Pork"
            };
            SubCategory subCategory12 = new SubCategory
            {
                CategoryId = 2,
                Name = "Poultry"
            };
            SubCategory subCategory13 = new SubCategory
            {
                CategoryId = 2,
                Name = "Pate"
            };
            SubCategory subCategory14 = new SubCategory
            {
                CategoryId = 2,
                Name = "Beef"
            };
            SubCategory subCategory15 = new SubCategory
            {
                CategoryId = 2,
                Name = "Venison"
            };
            SubCategory subCategory16 = new SubCategory
            {
                CategoryId = 2,
                Name = "Cold cuts"
            };
            SubCategory subCategory17 = new SubCategory
            {
                CategoryId = 3,
                Name = "Seeds and grains"
            };
            SubCategory subCategory18 = new SubCategory
            {
                CategoryId = 3,
                Name = "Nuts"
            };
            SubCategory subCategory19 = new SubCategory
            {
                CategoryId = 3,
                Name = "Spices"
            };
            SubCategory subCategory20 = new SubCategory
            {
                CategoryId = 4,
                Name = "Bars,waffles"
            };
            SubCategory subCategory21 = new SubCategory
            {
                CategoryId = 4,
                Name = "Cookie"
            };
            SubCategory subCategory22 = new SubCategory
            {
                CategoryId = 4,
                Name = "Chocolates"
            };
            SubCategory subCategory23 = new SubCategory
            {
                CategoryId = 4,
                Name = "Jelly beans and marshmallows"
            };
            SubCategory subCategory24 = new SubCategory
            {
                CategoryId = 4,
                Name = "Puddings,porridge and dessert"
            };
            SubCategory subCategory25 = new SubCategory
            {
                CategoryId = 4,
                Name = "Candies,drops and lollipops"
            };
            SubCategory subCategory26 = new SubCategory
            {
                CategoryId = 4,
                Name = "Ice cream"
            };
            SubCategory subCategory27 = new SubCategory
            {
                CategoryId = 4,
                Name = "Other"
            };
            SubCategory subCategory28 = new SubCategory
            {
                CategoryId = 4,
                Name = "Cakes and pies"
            };
            SubCategory subCategory29 = new SubCategory
            {
                CategoryId = 4,
                Name = "Chocolates, pralines and box of chocolates"
            };
            SubCategory subCategory30 = new SubCategory
            {
                CategoryId = 4,
                Name = "Snakcs"
            };
            SubCategory subCategory31 = new SubCategory
            {
                CategoryId = 5,
                Name = "Dried mushrooms"
            };
            SubCategory subCategory32 = new SubCategory
            {
                CategoryId = 5,
                Name = "Fresh mushrooms"
            };
            SubCategory subCategory33 = new SubCategory
            {
                CategoryId = 6,
                Name = "Eggs"
            };
            SubCategory subCategory34 = new SubCategory
            {
                CategoryId = 6,
                Name = "Butter"
            };
            SubCategory subCategory35 = new SubCategory
            {
                CategoryId = 6,
                Name = "Cheese"
            };
            SubCategory subCategory36 = new SubCategory
            {
                CategoryId = 6,
                Name = "Yoghurts"
            };
            SubCategory subCategory37 = new SubCategory
            {
                CategoryId = 6,
                Name = "Buttermilk,whey"
            };
            SubCategory subCategory38 = new SubCategory
            {
                CategoryId = 6,
                Name = "Cream"
            };
            SubCategory subCategory39 = new SubCategory
            {
                CategoryId = 6,
                Name = "Kefir"
            };
            SubCategory subCategory40 = new SubCategory
            {
                CategoryId = 6,
                Name = "Milk"
            };
            SubCategory subCategory41 = new SubCategory
            {
                CategoryId = 7,
                Name = "Buns"
            };
            SubCategory subCategory42 = new SubCategory
            {
                CategoryId = 7,
                Name = "Bread"
            };
            SubCategory subCategory43 = new SubCategory
            {
                CategoryId = 7,
                Name = "Crispbread"
            };
            SubCategory subCategory44 = new SubCategory
            {
                CategoryId = 7,
                Name = "Sweeet bread"
            };
            SubCategory subCategory45 = new SubCategory
            {
                CategoryId = 8,
                Name = "Margarine"
            };
            SubCategory subCategory46 = new SubCategory
            {
                CategoryId = 8,
                Name = "VegetableButter"
            };
            SubCategory subCategory47 = new SubCategory
            {
                CategoryId = 8,
                Name = "Oils and olive oils"
            };
            SubCategory subCategory48 = new SubCategory
            {
                CategoryId = 8,
                Name = "Lard"
            };
            SubCategory subCategory49 = new SubCategory
            {
                CategoryId = 9,
                Name = "Sugar"
            };
            SubCategory subCategory50 = new SubCategory
            {
                CategoryId = 9,
                Name = "Groats"
            };
            SubCategory subCategory51 = new SubCategory
            {
                CategoryId = 9,
                Name = "Pasta"
            };
            SubCategory subCategory52 = new SubCategory
            {
                CategoryId = 9,
                Name = "Flour"
            };
            SubCategory subCategory53 = new SubCategory
            {
                CategoryId = 9,
                Name = "Muesli,bran,cereals"
            };
            SubCategory subCategory54 = new SubCategory
            {
                CategoryId = 9,
                Name = "Rice"
            };
            SubCategory subCategory55 = new SubCategory
            {
                CategoryId = 10,
                Name = "Alcohol"
            };
            SubCategory subCategory56 = new SubCategory
            {
                CategoryId = 10,
                Name = "Fizzy drinks"
            };
            SubCategory subCategory57 = new SubCategory
            {
                CategoryId = 10,
                Name = "Syrups"
            };
            SubCategory subCategory58 = new SubCategory
            {
                CategoryId = 10,
                Name = "Tea"
            };
            SubCategory subCategory59 = new SubCategory
            {
                CategoryId = 10,
                Name = "Drinks"
            };
            SubCategory subCategory60 = new SubCategory
            {
                CategoryId = 10,
                Name = "Others"
            };
            SubCategory subCategory61 = new SubCategory
            {
                CategoryId = 10,
                Name = "Coffee"
            };
            SubCategory subCategory62 = new SubCategory
            {
                CategoryId = 10,
                Name = "Juices"
            };
            SubCategory subCategory63 = new SubCategory
            {
                CategoryId = 11,
                Name = "Caviar"
            };
            SubCategory subCategory64 = new SubCategory
            {
                CategoryId = 11,
                Name = "Mollusca"
            };
            SubCategory subCategory65 = new SubCategory
            {
                CategoryId = 11,
                Name = "Preserves and fish dishes"
            };
            SubCategory subCategory66 = new SubCategory
            {
                CategoryId = 11,
                Name = "Fish"
            };
            SubCategory subCategory67 = new SubCategory
            {
                CategoryId = 11,
                Name = "Shellfish"
            };
            SubCategory subCategory68 = new SubCategory
            {
                CategoryId = 12,
                Name = "Frozen fruit"
            };
            SubCategory subCategory69 = new SubCategory
            {
                CategoryId = 12,
                Name = "Dried fruit"
            };
            SubCategory subCategory70 = new SubCategory
            {
                CategoryId = 12,
                Name = "Fresh fruit"
            };
            SubCategory subCategory71 = new SubCategory
            {
                CategoryId = 12,
                Name = "Fruit preserves"
            };
            SubCategory subCategory72 = new SubCategory
            {
                CategoryId = 12,
                Name = "Vegetable preserve"
            };
            SubCategory subCategory73 = new SubCategory
            {
                CategoryId = 12,
                Name = "Frozen vegetables"
            };
            SubCategory subCategory74 = new SubCategory
            {
                CategoryId = 12,
                Name = "Fresh vegetables"
            };

            Product product1 = new Product
            {
                Name = "Yoghurt Salad dressing",
                SubCategoryId = 1,
                Protein = 2,
                HealthIndex = 2,
                Calories = 215
            };
            Product product2 = new Product
            {
                Name = "Mayo",
                SubCategoryId = 1,
                Protein = 1,
                HealthIndex = 1,
                Calories = 663
            };
            Product product3 = new Product
            {
                Name = "Fried Zucchini",
                SubCategoryId = 2,
                Protein = 2.6M,
                HealthIndex = 3,
                Calories = 63
            };
            Product product4 = new Product
            {
                Name = "Vegetable salad",
                SubCategoryId = 2,
                Protein = 0.8M,
                HealthIndex = 4,
                Calories = 34
            };
            Product product5 = new Product
            {
                Name = "Salmon with spinach",
                SubCategoryId = 3,
                Protein = 2.9M,
                HealthIndex = 5,
                Calories = 60
            };
            Product product6 = new Product
            {
                Name = "Sushi Fotomaki",
                SubCategoryId = 3,
                Protein = 3.1M,
                HealthIndex = 4,
                Calories = 60
            };
            Product product7 = new Product
            {
                Name = "Chicken Fajita Sandwich",
                SubCategoryId = 4,
                Protein = 11.5M,
                HealthIndex = 3,
                Calories = 157
            };
            Product product8 = new Product
            {
                Name = "Hamburger triple whopper",
                SubCategoryId = 4,
                Protein = 15,
                HealthIndex = 2,
                Calories = 229
            };
            Product product9 = new Product
            {
                Name = "Tortilla with chicken",
                SubCategoryId = 5,
                Protein = 19.1M,
                HealthIndex = 3,
                Calories = 339
            };
            Product product10 = new Product
            {
                Name = "Provencal dish",
                SubCategoryId = 5,
                Protein = 5.4M,
                HealthIndex = 4,
                Calories = 138
            };
            Product product11 = new Product
            {
                Name = "Broccoli soup",
                SubCategoryId = 6,
                Protein = 6,
                HealthIndex = 5,
                Calories = 36
            };
            Product product12 = new Product
            {
                Name = "Chicken soup with pasta",
                SubCategoryId = 6,
                Protein = 2.6M,
                HealthIndex = 4,
                Calories = 52
            };
            Product product13 = new Product
            {
                Name = "Roast beef with souce",
                SubCategoryId = 7,
                Protein = 11.5M,
                HealthIndex = 5,
                Calories = 73
            };
            Product product14 = new Product
            {
                Name = "Crispy chicken fillet",
                SubCategoryId = 7,
                Protein = 19,
                HealthIndex = 3,
                Calories = 218
            };
            Product product15 = new Product
            {
                Name = "Fried egg",
                SubCategoryId = 8,
                Protein = 10M,
                HealthIndex = 4,
                Calories = 170
            };
            Product product16 = new Product
            {
                Name = "Eggs Mayonnaise",
                SubCategoryId = 8,
                Protein = 9.8M,
                HealthIndex = 5,
                Calories = 274
            };
            Product product17 = new Product
            {
                Name = "Mutton, shoulder",
                SubCategoryId = 9,
                Protein = 15.6M,
                HealthIndex = 4,
                Calories = 284
            };
            Product product18 = new Product
            {
                Name = "Mutton, haunch",
                SubCategoryId = 9,
                Protein = 18,
                HealthIndex = 5,
                Calories = 232
            };
            Product product19 = new Product
            {
                Name = "Mutton, back",
                SubCategoryId = 9,
                Protein = 15.6M,
                HealthIndex = 5,
                Calories = 284
            };

            Product product20 = new Product
            {
                Name = "Lamb,tenderloin",
                SubCategoryId = 10,
                Protein = 19,
                HealthIndex = 5,
                Calories = 203
            };
            Product product21 = new Product
            {
                Name = "Veal,ham",
                SubCategoryId = 10,
                Protein = 36,
                HealthIndex = 5,
                Calories = 201
            };
            Product product22 = new Product
            {
                Name = "Pork,boneless bacon",
                SubCategoryId = 11,
                Protein = 10.1M,
                HealthIndex = 5,
                Calories = 501
            };
            Product product23 = new Product
            {
                Name = "Pork,minced ham",
                SubCategoryId = 11,
                Protein = 18,
                HealthIndex = 5,
                Calories = 261
            };
            Product product24 = new Product
            {
                Name = "Chicken carcass",
                SubCategoryId = 12,
                Protein = 18.5M,
                HealthIndex = 5,
                Calories = 202
            };
            Product product25 = new Product
            {
                Name = "Chicken breast without skin",
                SubCategoryId = 12,
                Protein = 21.5M,
                HealthIndex = 5,
                Calories = 99
            };
            Product product26 = new Product
            {
                Name = "Turkey Terrine",
                SubCategoryId = 13,
                Protein = 8.4M,
                HealthIndex = 5,
                Calories = 240
            };
            Product product27 = new Product
            {
                Name = "Pate with deer",
                SubCategoryId = 13,
                Protein = 11.2M,
                HealthIndex = 5,
                Calories = 315
            };
            Product product28 = new Product
            {
                Name = "Beef",
                SubCategoryId = 14,
                Protein = 21.7M,
                HealthIndex = 5,
                Calories = 107
            };
            Product product29 = new Product
            {
                Name = "Beef,thin flank",
                SubCategoryId = 14,
                Protein = 19.3M,
                HealthIndex = 5,
                Calories = 217
            };
            Product product30 = new Product
            {
                Name = "Boar Meat",
                SubCategoryId = 15,
                Protein = 21.5M,
                HealthIndex = 5,
                Calories = 122
            };
            Product product31 = new Product
            {
                Name = "Partridge meat",
                SubCategoryId = 15,
                Protein = 22.1M,
                HealthIndex = 5,
                Calories = 108
            };
            Product product32 = new Product
            {
                Name = "Chicken frankfurter",
                SubCategoryId = 16,
                Protein = 10.8M,
                HealthIndex = 4,
                Calories = 259
            };
            Product product33 = new Product
            {
                Name = "Silesian sausage",
                SubCategoryId = 16,
                Protein = 18.4M,
                HealthIndex = 4,
                Calories = 210
            };
            Product product34 = new Product
            {
                Name = "Chia",
                SubCategoryId = 17,
                Protein = 15.6M,
                HealthIndex = 5,
                Calories = 490
            };
            Product product35 = new Product
            {
                Name = "Pumpkin seeds",
                SubCategoryId = 17,
                Protein = 24.5M,
                HealthIndex = 5,
                Calories = 556
            };
            Product product36 = new Product
            {
                Name = "Almonds",
                SubCategoryId = 18,
                Protein = 20,
                HealthIndex = 5,
                Calories = 572
            };
            Product product37 = new Product
            {
                Name = "Coconut",
                SubCategoryId = 18,
                Protein = 3.4M,
                HealthIndex = 5,
                Calories = 335
            };
            Product product38 = new Product
            {
                Name = "Powdered ginger",
                SubCategoryId = 19,
                Protein = 9.9M,
                HealthIndex = 5,
                Calories = 361
            };
            Product product39 = new Product
            {
                Name = "Oregano",
                SubCategoryId = 19,
                Protein = 11,
                HealthIndex = 4,
                Calories = 306
            };
            Product product40 = new Product
            {
                Name = "Milky-white Aero bar",
                SubCategoryId = 20,
                Protein = 7.8M,
                HealthIndex = 3,
                Calories = 553
            };
            Product product41 = new Product
            {
                Name = "Cocoa Kinder Delice bar",
                SubCategoryId = 20,
                Protein = 5.8M,
                HealthIndex = 3,
                Calories = 460
            };
            Product product42 = new Product
            {
                Name = "Died fruit cookies with cranberry",
                SubCategoryId = 21,
                Protein = 9.7M,
                HealthIndex = 3,
                Calories = 496
            };
            Product product43 = new Product
            {
                Name = "Cookies with pieces of chocolate and nuts ",
                SubCategoryId = 21,
                Protein = 6,
                HealthIndex = 3,
                Calories = 505
            };
            Product product44 = new Product
            {
                Name = "Milky bubble chocolate",
                SubCategoryId = 22,
                Protein = 7,
                HealthIndex = 3,
                Calories = 520
            };
            Product product45 = new Product
            {
                Name = "Bitter chocolate 99%",
                SubCategoryId = 22,
                Protein = 13,
                HealthIndex = 4,
                Calories = 530
            };
            Product product46 = new Product
            {
                Name = "Haribo gold bears jellies",
                SubCategoryId = 23,
                Protein = 6.9M,
                HealthIndex = 1,
                Calories = 343
            };
            Product product47 = new Product
            {
                Name = "Marshmallow",
                SubCategoryId = 23,
                Protein = 1.8M,
                HealthIndex = 1,
                Calories = 318
            };
            Product product48 = new Product
            {
                Name = "Chocolate pudding",
                SubCategoryId = 24,
                Protein = 3.3M,
                HealthIndex = 2,
                Calories = 97
            };
            Product product49 = new Product
            {
                Name = "Strawberry porridge Activia",
                SubCategoryId = 24,
                Protein = 3.2M,
                HealthIndex = 4,
                Calories = 85
            };
            Product product50 = new Product
            {
                Name = "Creamy dragees",
                SubCategoryId = 25,
                Protein = 3.2M,
                HealthIndex = 1,
                Calories = 474
            };
            Product product51 = new Product
            {
                Name = "M&M's candies",
                SubCategoryId = 25,
                Protein = 10,
                HealthIndex = 2,
                Calories = 490
            };
            Product product52 = new Product
            {
                Name = "Ice cream sandwich",
                SubCategoryId = 26,
                Protein = 1.2M,
                HealthIndex = 2,
                Calories = 110
            };
            Product product53 = new Product
            {
                Name = "Kitkat ice cream",
                SubCategoryId = 26,
                Protein = 3.1M,
                HealthIndex = 2,
                Calories = 213
            };
            Product product54 = new Product
            {
                Name = "White nougat with almonds",
                SubCategoryId = 27,
                Protein = 4.9M,
                HealthIndex = 3,
                Calories = 441
            };
            Product product55 = new Product
            {
                Name = "Waffles",
                SubCategoryId = 27,
                Protein = 6.8M,
                HealthIndex = 2,
                Calories = 466
            };
            Product product56 = new Product
            {
                Name = "Blueberry Muffin",
                SubCategoryId = 28,
                Protein = 5.2M,
                HealthIndex = 2,
                Calories = 385
            };
            Product product57 = new Product
            {
                Name = "Nut Cake",
                SubCategoryId = 28,
                Protein = 12,
                HealthIndex = 2,
                Calories = 465
            };
            Product product58 = new Product
            {
                Name = "Milka Thank you chocolates",
                SubCategoryId = 29,
                Protein = 7.1M,
                HealthIndex = 2,
                Calories = 560
            };
            Product product59 = new Product
            {
                Name = "After Eight mint chocolates",
                SubCategoryId = 29,
                Protein = 2.5M,
                HealthIndex = 3,
                Calories = 428
            };
            Product product60 = new Product
            {
                Name = "Pringles potato chips",
                SubCategoryId = 30,
                Protein = 3.8M,
                HealthIndex = 2,
                Calories = 522
            };
            Product product61 = new Product
            {
                Name = "Butter popcorn",
                SubCategoryId = 30,
                Protein = 9,
                HealthIndex = 2,
                Calories = 451
            };
            Product product62 = new Product
            {
                Name = "Dried champingnon",
                SubCategoryId = 31,
                Protein = 10,
                HealthIndex = 4,
                Calories = 296
            };
            Product product63 = new Product
            {
                Name = "Bolete mushroom",
                SubCategoryId = 31,
                Protein = 20.3M,
                HealthIndex = 2,
                Calories = 362
            };
            Product product64 = new Product
            {
                Name = "Oyster mushroom",
                SubCategoryId = 32,
                Protein = 3.3M,
                HealthIndex = 3,
                Calories = 33
            };
            Product product65 = new Product
            {
                Name = "Boletus",
                SubCategoryId = 32,
                Protein = 1.7M,
                HealthIndex = 3,
                Calories = 39
            };
            Product product66 = new Product
            {
                Name = "Whole hen egg(boiled)",
                SubCategoryId = 33,
                Protein = 12.6M,
                HealthIndex = 5,
                Calories = 155
            };
            Product product67 = new Product
            {
                Name = "Whole hen egg(raw)",
                SubCategoryId = 33,
                Protein = 12.5M,
                HealthIndex = 2,
                Calories = 139
            };
            Product product68 = new Product
            {
                Name = "Butter light",
                SubCategoryId = 34,
                Protein = 0.7M,
                HealthIndex = 1,
                Calories = 375
            };
            Product product69 = new Product
            {
                Name = "Butter with vegetable oil",
                SubCategoryId = 34,
                Protein = 1,
                HealthIndex = 1,
                Calories = 730
            };
            Product product70 = new Product
            {
                Name = "Cheddar",
                SubCategoryId = 35,
                Protein = 25,
                HealthIndex = 3,
                Calories = 334
            };
            Product product71 = new Product
            {
                Name = "Camembert cheese",
                SubCategoryId = 35,
                Protein = 21.4M,
                HealthIndex = 4,
                Calories = 291
            };
            Product product72 = new Product
            {
                Name = "Natural yoghurt",
                SubCategoryId = 36,
                Protein = 4,
                HealthIndex = 5,
                Calories = 38
            };
            Product product73 = new Product
            {
                Name = "Fruit yoghurt",
                SubCategoryId = 36,
                Protein = 2.5M,
                HealthIndex = 5,
                Calories = 90
            };
            Product product74 = new Product
            {
                Name = "Peach buttermilk",
                SubCategoryId = 37,
                Protein = 2.9M,
                HealthIndex = 4,
                Calories = 55
            };
            Product product75 = new Product
            {
                Name = "Stracciatella buttermilk",
                SubCategoryId = 37,
                Protein = 3.3M,
                HealthIndex = 3,
                Calories = 92
            };
            Product product76 = new Product
            {
                Name = "Whipped cream",
                SubCategoryId = 38,
                Protein = 2.5M,
                HealthIndex = 3,
                Calories = 231
            };
            Product product77 = new Product
            {
                Name = "Cream 18%",
                SubCategoryId = 38,
                Protein = 2.3M,
                HealthIndex = 3,
                Calories = 189
            };
            Product product78 = new Product
            {
                Name = "Natural kefir",
                SubCategoryId = 39,
                Protein = 3.6M,
                HealthIndex = 3,
                Calories = 51
            };
            Product product79 = new Product
            {
                Name = "Strawberry kefir",
                SubCategoryId = 39,
                Protein = 2.8M,
                HealthIndex = 5,
                Calories = 79
            };
            Product product80 = new Product
            {
                Name = "Loctose-Free Milk",
                SubCategoryId = 40,
                Protein = 3.15M,
                HealthIndex = 5,
                Calories = 46
            };
            Product product81 = new Product
            {
                Name = "Raw milk, straight from the cow",
                SubCategoryId = 40,
                Protein = 3,
                HealthIndex = 5,
                Calories = 67
            };
            Product product82 = new Product
            {
                Name = "Wholemeal roll",
                SubCategoryId = 41,
                Protein = 9,
                HealthIndex = 4,
                Calories = 252
            };
            Product product83 = new Product
            {
                Name = "Croissant",
                SubCategoryId = 41,
                Protein = 8.2M,
                HealthIndex = 4,
                Calories = 331
            };
            Product product84 = new Product
            {
                Name = "Wholemeal bread",
                SubCategoryId = 42,
                Protein = 8.3M,
                HealthIndex = 4,
                Calories = 221
            };
            Product product85 = new Product
            {
                Name = "Bread wiht sesame",
                SubCategoryId = 42,
                Protein = 7.2M,
                HealthIndex = 4,
                Calories = 268
            };
            Product product86 = new Product
            {
                Name = "Crispbread",
                SubCategoryId = 43,
                Protein = 11,
                HealthIndex = 3,
                Calories = 360
            };
            Product product87 = new Product
            {
                Name = "Rusks",
                SubCategoryId = 43,
                Protein = 11.1M,
                HealthIndex = 3,
                Calories = 373
            };
            Product product88 = new Product
            {
                Name = "Pastry with custard",
                SubCategoryId = 44,
                Protein = 7.1M,
                HealthIndex = 3,
                Calories = 269
            };
            Product product89 = new Product
            {
                Name = "Donut",
                SubCategoryId = 44,
                Protein = 4,
                HealthIndex = 3,
                Calories = 490
            };
            Product product90 = new Product
            {
                Name = "Margarine Spread",
                SubCategoryId = 45,
                Protein = 0.1M,
                HealthIndex = 1,
                Calories = 540
            };
            Product product91 = new Product
            {
                Name = "Breakfast margarin",
                SubCategoryId = 45,
                Protein = 0.3M,
                HealthIndex = 1,
                Calories = 534
            };
            Product product92 = new Product
            {
                Name = "Peanut butter",
                SubCategoryId = 46,
                Protein = 28,
                HealthIndex = 2,
                Calories = 637
            };
            Product product93 = new Product
            {
                Name = "Vegetable butter",
                SubCategoryId = 46,
                Protein = 0.1M,
                HealthIndex = 1,
                Calories = 721
            };
            Product product94 = new Product
            {
                Name = "Sunflower oil",
                SubCategoryId = 47,
                Protein = 0.1M,
                HealthIndex = 2,
                Calories = 884
            };
            Product product95 = new Product
            {
                Name = "Olive-pomace oil",
                SubCategoryId = 47,
                Protein = 0.1M,
                HealthIndex = 2,
                Calories = 824
            };
            Product product96 = new Product
            {
                Name = "Goose lard",
                SubCategoryId = 48,
                Protein = 0.1M,
                HealthIndex = 1,
                Calories = 900
            };
            Product product97 = new Product
            {
                Name = "Lard with cracklings",
                SubCategoryId = 48,
                Protein = 3.1M,
                HealthIndex = 1,
                Calories = 862
            };
            Product product98 = new Product
            {
                Name = "White sugar",
                SubCategoryId = 49,
                Protein = 0.1M,
                HealthIndex = 1,
                Calories = 405
            };
            Product product99 = new Product
            {
                Name = "Brown sugar",
                SubCategoryId = 49,
                Protein = 0.1M,
                HealthIndex = 1,
                Calories = 396
            };
            Product product100 = new Product
            {
                Name = "Buckwheat groats",
                SubCategoryId = 50,
                Protein = 12.6M,
                HealthIndex = 5,
                Calories = 336
            };
            Product product101 = new Product
            {
                Name = "Pearl barley",
                SubCategoryId = 50,
                Protein = 6.9M,
                HealthIndex = 5,
                Calories = 327
            };
            Product product102 = new Product
            {
                Name = "Boiled gluten-free pasta",
                SubCategoryId = 51,
                Protein = 1.6M,
                HealthIndex = 3,
                Calories = 128
            };
            Product product103 = new Product
            {
                Name = "Lasagne pasta",
                SubCategoryId = 51,
                Protein = 11.5M,
                HealthIndex = 3,
                Calories = 350
            };
            Product product104 = new Product
            {
                Name = "Whole-wheat flour",
                SubCategoryId = 52,
                Protein = 9,
                HealthIndex = 2,
                Calories = 294
            };
            Product product105 = new Product
            {
                Name = "Potato flour",
                SubCategoryId = 52,
                Protein = 6.9M,
                HealthIndex = 2,
                Calories = 340
            };
            Product product106 = new Product
            {
                Name = "Raspberry muesli bar",
                SubCategoryId = 53,
                Protein = 5.2M,
                HealthIndex = 3,
                Calories = 384
            };
            Product product107 = new Product
            {
                Name = "Chocolate muesli",
                SubCategoryId = 53,
                Protein = 9.4M,
                HealthIndex = 3,
                Calories = 455
            };
            Product product108 = new Product
            {
                Name = "White rice",
                SubCategoryId = 54,
                Protein = 6.7M,
                HealthIndex = 3,
                Calories = 344
            };
            Product product109 = new Product
            {
                Name = "Brown rice",
                SubCategoryId = 54,
                Protein = 7.1M,
                HealthIndex = 3,
                Calories = 322
            };
            Product product110 = new Product
            {
                Name = "Whisky",
                SubCategoryId = 55,
                Protein = 0,
                HealthIndex = 1,
                Calories = 220
            };
            Product product111 = new Product
            {
                Name = "Tequila",
                SubCategoryId = 55,
                Protein = 0,
                HealthIndex = 1,
                Calories = 231
            };
            Product product112 = new Product
            {
                Name = "Burn",
                SubCategoryId = 56,
                Protein = 0.4M,
                HealthIndex = 2,
                Calories = 57
            };
            Product product113 = new Product
            {
                Name = "Coca-Cola",
                SubCategoryId = 56,
                Protein = 0,
                HealthIndex = 2,
                Calories = 42
            };
            Product product114 = new Product
            {
                Name = "Ginger syrup",
                SubCategoryId = 57,
                Protein = 0,
                HealthIndex = 3,
                Calories = 279
            };
            Product product115 = new Product
            {
                Name = "Cherry syrup",
                SubCategoryId = 57,
                Protein = 0,
                HealthIndex = 3,
                Calories = 228
            };
            Product product116 = new Product
            {
                Name = "Black tea (without sugar)",
                SubCategoryId = 58,
                Protein = 0.1M,
                HealthIndex = 3,
                Calories = 1
            };
            Product product117 = new Product
            {
                Name = "Green tea (without sugar)",
                SubCategoryId = 58,
                Protein = 0.1M,
                HealthIndex = 3,
                Calories = 1
            };
            Product product118 = new Product
            {
                Name = "Red Frugo",
                SubCategoryId = 59,
                Protein = 0,
                HealthIndex = 3,
                Calories = 46
            };
            Product product119 = new Product
            {
                Name = "Kiwi drink",
                SubCategoryId = 59,
                Protein = 0.1M,
                HealthIndex = 3,
                Calories = 43
            };
            Product product120 = new Product
            {
                Name = "Chocolate drink",
                SubCategoryId = 60,
                Protein = 3.9M,
                HealthIndex = 2,
                Calories = 94
            };
            Product product121 = new Product
            {
                Name = "Powerade",
                SubCategoryId = 60,
                Protein = 0,
                HealthIndex = 2,
                Calories = 21
            };
            Product product122 = new Product
            {
                Name = "Cappuccino coffee(Prepared)",
                SubCategoryId = 61,
                Protein = 2.6M,
                HealthIndex = 2,
                Calories = 48
            };
            Product product123 = new Product
            {
                Name = "Coffee without milk and sugar(prepared)",
                SubCategoryId = 61,
                Protein = 0.2M,
                HealthIndex = 2,
                Calories = 5
            };
            Product product124 = new Product
            {
                Name = "Banana-carrot-apple juice",
                SubCategoryId = 62,
                Protein = 0.3M,
                HealthIndex = 5,
                Calories = 49
            };
            Product product125 = new Product
            {
                Name = "Multivitamin juice",
                SubCategoryId = 62,
                Protein = 0.1M,
                HealthIndex = 5,
                Calories = 41
            };
            Product product126 = new Product
            {
                Name = "Red caviar",
                SubCategoryId = 63,
                Protein = 11,
                HealthIndex = 4,
                Calories = 90
            };
            Product product127 = new Product
            {
                Name = "Wasabi caviar",
                SubCategoryId = 63,
                Protein = 2,
                HealthIndex = 3,
                Calories = 16
            };
            Product product128 = new Product
            {
                Name = "Oysters",
                SubCategoryId = 64,
                Protein = 5,
                HealthIndex = 3,
                Calories = 85
            };
            Product product129 = new Product
            {
                Name = "Marinated mussels",
                SubCategoryId = 64,
                Protein = 18.4M,
                HealthIndex = 3,
                Calories = 117
            };
            Product product130 = new Product
            {
                Name = "Fish in tomato sauce",
                SubCategoryId = 65,
                Protein = 5.6M,
                HealthIndex = 4,
                Calories = 69
            };
            Product product131 = new Product
            {
                Name = "Frozen fish sticks",
                SubCategoryId = 65,
                Protein = 8.5M,
                HealthIndex = 3,
                Calories = 161
            };
            Product product132 = new Product
            {
                Name = "Atlantic salmon",
                SubCategoryId = 66,
                Protein = 19.8M,
                HealthIndex = 5,
                Calories = 192
            };
            Product product133 = new Product
            {
                Name = "Tuna",
                SubCategoryId = 66,
                Protein = 23.7M,
                HealthIndex = 5,
                Calories = 137
            };
            Product product134 = new Product
            {
                Name = "Lobster",
                SubCategoryId = 67,
                Protein = 18.8M,
                HealthIndex = 5,
                Calories = 85
            };
            Product product135 = new Product
            {
                Name = "Crab",
                SubCategoryId = 67,
                Protein = 19.4M,
                HealthIndex = 5,
                Calories = 93
            };
            Product product136 = new Product
            {
                Name = "Frozen raspberries",
                SubCategoryId = 68,
                Protein = 1.3M,
                HealthIndex = 4,
                Calories = 29
            };
            Product product137 = new Product
            {
                Name = "Frozen blueberries",
                SubCategoryId = 68,
                Protein = 0.8M,
                HealthIndex = 4,
                Calories = 45
            };
            Product product138 = new Product
            {
                Name = "Dried mango",
                SubCategoryId = 69,
                Protein = 2.9M,
                HealthIndex = 4,
                Calories = 289
            };
            Product product139 = new Product
            {
                Name = "Dried apples",
                SubCategoryId = 69,
                Protein = 2.1M,
                HealthIndex = 4,
                Calories = 238
            };
            Product product140 = new Product
            {
                Name = "Avocado",
                SubCategoryId = 70,
                Protein = 2,
                HealthIndex = 5,
                Calories = 160
            };
            Product product141 = new Product
            {
                Name = "Watermelon",
                SubCategoryId = 70,
                Protein = 0.6M,
                HealthIndex = 5,
                Calories = 36
            };
            Product product142 = new Product
            {
                Name = "Cherry jam sweetened with fructose",
                SubCategoryId = 71,
                Protein = 0.5M,
                HealthIndex = 3,
                Calories = 138
            };
            Product product143 = new Product
            {
                Name = "Low-sugar peach confiture",
                SubCategoryId = 71,
                Protein = 0.6M,
                HealthIndex = 3,
                Calories = 189
            };
            Product product144 = new Product
            {
                Name = "Antipasti,green peppers stuffed with cheese",
                SubCategoryId = 72,
                Protein = 3,
                HealthIndex = 4,
                Calories = 163
            };
            Product product145 = new Product
            {
                Name = "Gherkin(pickled cucumber)",
                SubCategoryId = 72,
                Protein = 1,
                HealthIndex = 4,
                Calories = 15
            };
            Product product146 = new Product
            {
                Name = "Frozen broad beans",
                SubCategoryId = 73,
                Protein = 6.8M,
                HealthIndex = 4,
                Calories = 73
            };
            Product product147 = new Product
            {
                Name = "Frozen italian mix",
                SubCategoryId = 73,
                Protein = 1.8M,
                HealthIndex = 4,
                Calories = 25
            };
            Product product148 = new Product
            {
                Name = "Eggplant",
                SubCategoryId = 74,
                Protein = 1.1M,
                HealthIndex = 5,
                Calories = 21
            };
            Product product149 = new Product
            {
                Name = "Watercress",
                SubCategoryId = 74,
                Protein = 2.2M,
                HealthIndex = 5,
                Calories = 12
            };

            Gender gender1 = new Gender
            {
                GenderType = "Female"


            };
            Gender gender2 = new Gender
            {
                GenderType = "Male"

            };
            context.Genders.Add(gender1);
            context.Genders.Add(gender2);
            context.SaveChanges();
            PhysicalActivity physicalActivity1 = new PhysicalActivity
            {
                Name="Low",
                Description="Lack or almost no physical activity"
                
            };
            PhysicalActivity physicalActivity2 = new PhysicalActivity
            {
                Name = "Light",
                Description = "Walks or exercises 2 times a week"
            };
            PhysicalActivity physicalActivity3 = new PhysicalActivity
            {
                Name = "Average",
                Description = "Walks or exercises 4 times a week"
            };
            PhysicalActivity physicalActivity4 = new PhysicalActivity
            {
                Name = "Big",
                Description = "Walks or exercises 6 or more times a week"
            };
            context.PhysicalActivities.Add(physicalActivity1);
            context.PhysicalActivities.Add(physicalActivity2);
            context.PhysicalActivities.Add(physicalActivity3);
            context.PhysicalActivities.Add(physicalActivity4);
            context.SaveChanges();
            Repast repast1 = new Repast
            {
                Name = "Breakfast"
            };
            Repast repast2 = new Repast
            {
                Name="Lunch"
            };
            Repast repast3 = new Repast
            {
                Name="Dinner"
            };
            Repast repast4 = new Repast
            {
                Name="Snack"
            };
            context.Repasts.Add(repast1);
            context.Repasts.Add(repast2);
            context.Repasts.Add(repast3);
            context.Repasts.Add(repast4);
            context.SaveChanges();

            User user = new User
            {
                FirstName = "Admin",
                Surname="Admin",
                Mail="admin",
                IsActive=false,
                Password="byEye",
                CreateDate=DateTime.Now
            };
            context.Users.Add(user);
            context.SaveChanges();

            

            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);
            context.Categories.Add(category4);
            context.Categories.Add(category5);
            context.Categories.Add(category6);
            context.Categories.Add(category7);
            context.Categories.Add(category8);
            context.Categories.Add(category9);
            context.Categories.Add(category10);
            context.Categories.Add(category11);
            context.Categories.Add(category12);


            context.SubCategories.Add(subCategory1);
            context.SubCategories.Add(subCategory2);
            context.SubCategories.Add(subCategory3);
            context.SubCategories.Add(subCategory4);
            context.SubCategories.Add(subCategory5);
            context.SubCategories.Add(subCategory6);
            context.SubCategories.Add(subCategory7);
            context.SubCategories.Add(subCategory8);
            context.SubCategories.Add(subCategory9);
            context.SubCategories.Add(subCategory10);
            context.SubCategories.Add(subCategory11);
            context.SubCategories.Add(subCategory12);
            context.SubCategories.Add(subCategory13);
            context.SubCategories.Add(subCategory14);
            context.SubCategories.Add(subCategory15);
            context.SubCategories.Add(subCategory16);
            context.SubCategories.Add(subCategory17);
            context.SubCategories.Add(subCategory18);
            context.SubCategories.Add(subCategory19);
            context.SubCategories.Add(subCategory20);
            context.SubCategories.Add(subCategory21);
            context.SubCategories.Add(subCategory22);
            context.SubCategories.Add(subCategory23);
            context.SubCategories.Add(subCategory24);
            context.SubCategories.Add(subCategory25);
            context.SubCategories.Add(subCategory26);
            context.SubCategories.Add(subCategory27);
            context.SubCategories.Add(subCategory28);
            context.SubCategories.Add(subCategory29);
            context.SubCategories.Add(subCategory30);
            context.SubCategories.Add(subCategory31);
            context.SubCategories.Add(subCategory32);
            context.SubCategories.Add(subCategory33);
            context.SubCategories.Add(subCategory34);
            context.SubCategories.Add(subCategory35);
            context.SubCategories.Add(subCategory36);
            context.SubCategories.Add(subCategory37);
            context.SubCategories.Add(subCategory38);
            context.SubCategories.Add(subCategory39);
            context.SubCategories.Add(subCategory40);
            context.SubCategories.Add(subCategory41);
            context.SubCategories.Add(subCategory42);
            context.SubCategories.Add(subCategory43);
            context.SubCategories.Add(subCategory44);
            context.SubCategories.Add(subCategory45);
            context.SubCategories.Add(subCategory46);
            context.SubCategories.Add(subCategory47);
            context.SubCategories.Add(subCategory48);
            context.SubCategories.Add(subCategory49);
            context.SubCategories.Add(subCategory50);
            context.SubCategories.Add(subCategory51);
            context.SubCategories.Add(subCategory52);
            context.SubCategories.Add(subCategory53);
            context.SubCategories.Add(subCategory54);
            context.SubCategories.Add(subCategory55);
            context.SubCategories.Add(subCategory56);
            context.SubCategories.Add(subCategory57);
            context.SubCategories.Add(subCategory58);
            context.SubCategories.Add(subCategory59);
            context.SubCategories.Add(subCategory60);
            context.SubCategories.Add(subCategory61);
            context.SubCategories.Add(subCategory62);
            context.SubCategories.Add(subCategory63);
            context.SubCategories.Add(subCategory64);
            context.SubCategories.Add(subCategory65);
            context.SubCategories.Add(subCategory66);
            context.SubCategories.Add(subCategory67);
            context.SubCategories.Add(subCategory68);
            context.SubCategories.Add(subCategory69);
            context.SubCategories.Add(subCategory70);
            context.SubCategories.Add(subCategory71);
            context.SubCategories.Add(subCategory72);
            context.SubCategories.Add(subCategory73);
            context.SubCategories.Add(subCategory74);

            context.SaveChanges();

            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.Products.Add(product4);
            context.Products.Add(product5);
            context.Products.Add(product6);
            context.Products.Add(product7);
            context.Products.Add(product8);
            context.Products.Add(product9);
            context.Products.Add(product10);
            context.Products.Add(product11);
            context.Products.Add(product12);
            context.Products.Add(product13);
            context.Products.Add(product14);
            context.Products.Add(product15);
            context.Products.Add(product16);
            context.Products.Add(product17);
            context.Products.Add(product18);
            context.Products.Add(product19);
            context.Products.Add(product20);
            context.Products.Add(product21);
            context.Products.Add(product22);
            context.Products.Add(product23);
            context.Products.Add(product24);
            context.Products.Add(product25);
            context.Products.Add(product26);
            context.Products.Add(product27);
            context.Products.Add(product28);
            context.Products.Add(product29);
            context.Products.Add(product30);
            context.Products.Add(product31);
            context.Products.Add(product32);
            context.Products.Add(product33);
            context.Products.Add(product34);
            context.Products.Add(product35);
            context.Products.Add(product36);
            context.Products.Add(product37);
            context.Products.Add(product38);
            context.Products.Add(product39);
            context.Products.Add(product40);
            context.Products.Add(product41);
            context.Products.Add(product42);
            context.Products.Add(product43);
            context.Products.Add(product44);
            context.Products.Add(product45);
            context.Products.Add(product46);
            context.Products.Add(product47);
            context.Products.Add(product48);
            context.Products.Add(product49);
            context.Products.Add(product50);
            context.Products.Add(product51);
            context.Products.Add(product52);
            context.Products.Add(product53);
            context.Products.Add(product54);
            context.Products.Add(product55);
            context.Products.Add(product56);
            context.Products.Add(product57);
            context.Products.Add(product58);
            context.Products.Add(product59);
            context.Products.Add(product60);
            context.Products.Add(product61);
            context.Products.Add(product62);
            context.Products.Add(product63);
            context.Products.Add(product64);
            context.Products.Add(product65);
            context.Products.Add(product66);
            context.Products.Add(product67);
            context.Products.Add(product68);
            context.Products.Add(product69);
            context.Products.Add(product70);
            context.Products.Add(product71);
            context.Products.Add(product72);
            context.Products.Add(product73);
            context.Products.Add(product74);
            context.Products.Add(product75);
            context.Products.Add(product76);
            context.Products.Add(product77);
            context.Products.Add(product78);
            context.Products.Add(product79);
            context.Products.Add(product80);
            context.Products.Add(product81);
            context.Products.Add(product82);
            context.Products.Add(product83);
            context.Products.Add(product84);
            context.Products.Add(product85);
            context.Products.Add(product86);
            context.Products.Add(product87);
            context.Products.Add(product88);
            context.Products.Add(product89);
            context.Products.Add(product90);
            context.Products.Add(product91);
            context.Products.Add(product92);
            context.Products.Add(product93);
            context.Products.Add(product94);
            context.Products.Add(product95);
            context.Products.Add(product96);
            context.Products.Add(product97);
            context.Products.Add(product98);
            context.Products.Add(product99);
            context.Products.Add(product100);
            context.Products.Add(product101);
            context.Products.Add(product102);
            context.Products.Add(product103);
            context.Products.Add(product104);
            context.Products.Add(product105);
            context.Products.Add(product106);
            context.Products.Add(product107);
            context.Products.Add(product108);
            context.Products.Add(product109);
            context.Products.Add(product110);
            context.Products.Add(product111);
            context.Products.Add(product112);
            context.Products.Add(product113);
            context.Products.Add(product114);
            context.Products.Add(product115);
            context.Products.Add(product116);
            context.Products.Add(product117);
            context.Products.Add(product118);
            context.Products.Add(product119);
            context.Products.Add(product120);
            context.Products.Add(product121);
            context.Products.Add(product122);
            context.Products.Add(product123);
            context.Products.Add(product124);
            context.Products.Add(product125);
            context.Products.Add(product126);
            context.Products.Add(product127);
            context.Products.Add(product128);
            context.Products.Add(product129);
            context.Products.Add(product130);
            context.Products.Add(product131);
            context.Products.Add(product132);
            context.Products.Add(product133);
            context.Products.Add(product134);
            context.Products.Add(product135);
            context.Products.Add(product136);
            context.Products.Add(product137);
            context.Products.Add(product138);
            context.Products.Add(product139);
            context.Products.Add(product140);
            context.Products.Add(product141);
            context.Products.Add(product142);
            context.Products.Add(product143);
            context.Products.Add(product144);
            context.Products.Add(product145);
            context.Products.Add(product146);
            context.Products.Add(product147);
            context.Products.Add(product148);
            context.Products.Add(product149);
            context.SaveChanges();

            
            string path = Path.GetFullPath("CategoryPhotos");
            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] files = d.GetFiles("*.png");

            for (int i = 0; i <= files.Length-1; i++)
            {
                byte[] bytes = File.ReadAllBytes(files[i].FullName);
                Category category = new Category();
                category = context.Categories.Find(i + 1);
                category.Photo = bytes;
                context.SaveChanges();
            }
            string path1 = Path.GetFullPath("Subcategory Photos");
            DirectoryInfo c = new DirectoryInfo(path1);

            FileInfo[] filesforSubCategory = c.GetFiles("*.png");

            for (int i = 0; i <= filesforSubCategory.Length - 1; i++)
            {
                byte[] bytes = File.ReadAllBytes(filesforSubCategory[i].FullName);
                SubCategory subCategory = new SubCategory();
                subCategory = context.SubCategories.Find(i + 1);
                subCategory.Photo = bytes;
                context.SaveChanges();
            }
            string path2 = Path.GetFullPath("ProductPhotos");
            DirectoryInfo b = new DirectoryInfo(path2);

            FileInfo[] filesforProducts = b.GetFiles("*.png").OrderBy(a => a.CreationTime).ToArray();
            for (int i = 0; i <= filesforProducts.Length - 1; i++)
            {
                byte[] bytes = File.ReadAllBytes(filesforProducts[i].FullName);
                Product product = new Product();
                product = context.Products.Find(i + 1);
                product.Photo = bytes;
                context.SaveChanges();
            }

        }

    }
}
