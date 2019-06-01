﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RushAndCrush
{
    public partial class GameScreen : UserControl
    {
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, enterDown, escDown;
        List<Object> items = new List<Object>();
        List<Food> foods = new List<Food>();
        List<Drink> drinks = new List<Drink>();
        List<Toppings> toppings = new List<Toppings>();
        List<Customers> customers = new List<Customers>();

        //Relating to Levels
        List<Levels> levels = new List<Levels>();
        string levelNumber;
        int moodspeed;
        int number;
        int choice1;
        int choice2;
        int quota;


        //creating mood level 
        MoodLevel mood = new MoodLevel(500, 100, 100, 400, 500, 300, 100, 200, Color.Yellow);
        Object chooser;

        //creating speech bubbles
        Object speechbub = new Object(700, 10, 500, 540, Color.Black);
        int speechfoodw;
        int speechfoodh;

        //customers choice 
        List<Food> custochoice1 = new List<Food>();
        List<Toppings> custochoice2 = new List<Toppings>();
        List<Drink> custochoice3 = new List<Drink>();
        int c1, c2, c3;
        //to display the items the customers want 
        int cNum;
        //generating the amount of items the customers want, 
        int customerChoiceNumber;


        //your choice
        List<Food> yourchoice1 = new List<Food>();
        List<Toppings> yourchoice2 = new List<Toppings>();
        List<Drink> yourchoice3 = new List<Drink>();
        int y1, y2, y3;

        SolidBrush objectbrush = new SolidBrush(Color.Wheat);

        int customerNumber;
        int customerselector;

        int earnings;

        Random r = new Random();
        Image customerImage;

        int counterw = 1500;
        int counterh = 50;
        int counterx = 0;
        int countery = 600;

        int incounterw = 800;
        int incounterh = 375;
        int incounterx = 10;
        int incountery = 725;

        int holderw = 200;
        int holderh = 400;
        int holderx = 1290;
        int holdery = 100;

        int foodw = 120;
        int foodh = 172;

        int drinkw = 100;
        int drinkh = 150;
             
        

        public GameScreen()
        {
            InitializeComponent();
            //loading level1
            levelNumber = "level01";
            loadLevel01();
            loadLevel02();
            loadLevel03();
            OnStart();
            gameTimer.Enabled = true;

            switch (levelNumber)
            {
                case "level01":
                    moodspeed = Convert.ToInt16(levels[0].moodspeed);
                    number = Convert.ToInt16(levels[0].custonumber);
                    choice1 = Convert.ToInt16(levels[0].choiceone);
                    choice2 = Convert.ToInt16(levels[0].choicetwo);
                    quota = Convert.ToInt16(levels[0].quota);
                    break;
                case "level02":
                    moodspeed = Convert.ToInt16(levels[1].moodspeed);
                    number = Convert.ToInt16(levels[1].custonumber);
                    choice1 = Convert.ToInt16(levels[1].choiceone);
                    choice2 = Convert.ToInt16(levels[1].choicetwo);
                    quota = Convert.ToInt16(levels[1].quota);
                    break;
                case "level03":
                    moodspeed = Convert.ToInt16(levels[2].moodspeed);
                    number = Convert.ToInt16(levels[2].custonumber);
                    choice1 = Convert.ToInt16(levels[2].choiceone);
                    choice2 = Convert.ToInt16(levels[2].choicetwo);
                    quota = Convert.ToInt16(levels[2].quota);
                    break;
            }
        }

        //pressing keys
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Enter:
                    enterDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    break;
            }
        }

        //releasing key
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Left:
                    leftArrowDown = false;
                    if (chooser.x > 20)
                    {
                        chooser.chooserMove(foodw + 10, 0, "left");
                    }
                    Refresh();
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    if (chooser.x < 670)
                    {
                        chooser.chooserMove(foodw + 10, 0, "right");
                    }
                    Refresh();
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    if (chooser.y == 917)
                    {
                        chooser.chooserMove(0, foodh + 10, "up");
                    }
                    Refresh();
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    if (chooser.y == 735)
                    {
                        chooser.chooserMove(0, foodh + 10, "down");
                    }
                    Refresh();
                    break;
                case Keys.Enter:
                    enterDown = false;

                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }

        public void OnStart()
        {
            //creating counter
            Object counter = new Object(counterx, countery - (counterh / 2), counterw, counterh, Color.Black);
            //creating incounter
            Object incounter = new Object(incounterx, incountery, incounterw, incounterh, Color.White);
            //creating holder
            Object holder = new Object(holderx, holdery, holderw, holderh, Color.DarkRed);

            //creating the chooser
            chooser = new Object(20, 735, foodw, foodh, Color.Black);
            //foodw is 120
            //foodh is 172

            //creating foods 
            Food f1 = new Food(20, 735, foodw, foodh, RushAndCrush.Properties.Resources.whiteb);
            Food f2 = new Food(150, 735, foodw, foodh, RushAndCrush.Properties.Resources.brownb);
            Food f3 = new Food(280, 735, foodw, foodh, RushAndCrush.Properties.Resources.sesameb);
            Food f4 = new Food(410, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg1);
            Food f5 = new Food(540, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg2);
            Food f6 = new Food(670, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg3);
            Toppings t7 = new Toppings(20, 917, foodw, foodh, Color.Brown);
            Toppings t8 = new Toppings(150, 917, foodw, foodh, Color.Red);
            Toppings t9 = new Toppings(280, 917, foodw, foodh, Color.Yellow);
            Food f10 = new Food(410, 917, foodw, foodh, RushAndCrush.Properties.Resources.meat1);
            Food f11 = new Food(540, 917, foodw, foodh, RushAndCrush.Properties.Resources.meat2);
            Food f12 = new Food(670, 917, foodw, foodh, RushAndCrush.Properties.Resources.meat3);
            Drink dr1 = new Drink(holderx + (holderw - drinkw)/2, holdery + (holderh - drinkh - drinkh)/3, drinkw, drinkh, RushAndCrush.Properties.Resources.strawberryd);
            Drink dr2 = new Drink(holderx + (holderw - drinkw) / 2, holdery + (holderh - drinkh - drinkh)/3 + drinkh + (holderh - drinkh - drinkh) / 3, drinkw, drinkh, RushAndCrush.Properties.Resources.chocolated);

            //adding to list 
            items.Add(counter);
            items.Add(incounter);
            items.Add(holder);
            

            foods.Add(f1);
            foods.Add(f2);
            foods.Add(f3);
            foods.Add(f4);
            foods.Add(f5);
            foods.Add(f6);
            //foods.Add(f7);
            //foods.Add(f8);
            //foods.Add(f9);
            foods.Add(f10);
            foods.Add(f11);
            foods.Add(f12);

            toppings.Add(t7);
            toppings.Add(t8);
            toppings.Add(t9);

            drinks.Add(dr1);
            drinks.Add(dr2);

            //below are customers stuff

            customerselector = r.Next(1, 11);
            if (customerselector == 1) { customerImage = RushAndCrush.Properties.Resources.p1; }
            if (customerselector == 2) { customerImage = RushAndCrush.Properties.Resources.p2; }
            if (customerselector == 3) { customerImage = RushAndCrush.Properties.Resources.p3; }
            if (customerselector == 4) { customerImage = RushAndCrush.Properties.Resources.p4; }
            if (customerselector == 5) { customerImage = RushAndCrush.Properties.Resources.p5; }
            if (customerselector == 6) { customerImage = RushAndCrush.Properties.Resources.p6; }
            if (customerselector == 7) { customerImage = RushAndCrush.Properties.Resources.p7; }
            if (customerselector == 8) { customerImage = RushAndCrush.Properties.Resources.p8; }
            if (customerselector == 9) { customerImage = RushAndCrush.Properties.Resources.p9; }
            if (customerselector == 10) { customerImage = RushAndCrush.Properties.Resources.p10; }

            Customers c = new Customers(350, 479, 100, 100, customerImage);
            //400,475
            customers.Add(c);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach (Customers c in customers)
            {
                //moving the customers towards the counter
                c.CustoMove();

                if (c.x < 0){ c.x = 0; }
                if (c.y < 100){ c.y = 100; }
                if (c.h > 475){ c.h = 475; }
                if (c.w > 480){ c.w = 480; }
            }

            //starting the level
            mood.StartLevel(1);
            

            if (mood.levelHeight < 100)
            {
                mood.colour = Color.Red;
            }
            else if (mood.levelHeight > 300)
            {
                mood.colour = Color.Green;
            }
            else
            {
                mood.colour = Color.Yellow;
            }


            //customers' choices that are randomized
            customerChoiceNumber = r.Next(choice1, choice2);

            //level one only deals with one choice#
            if (customerChoiceNumber == 3)
            {
                //all of these supposedly show up in speech bubbles 
                c2 = r.Next(1, 4);

                if (c2 == 1)
                {
                    Toppings to = new Toppings(20, 917, speechfoodw, speechfoodh, Color.Brown);
                    custochoice2.Add(to);
                    
                }
                else if (c2 == 2)
                {
                    Toppings tt = new Toppings(150, 917, speechfoodw, speechfoodh, Color.Red);
                    custochoice2.Add(tt);
                }
                else if (c2 == 3)
                {
                    Toppings tth = new Toppings(280, 917, speechfoodw, speechfoodh, Color.Yellow);
                    custochoice2.Add(tth);
                }

                c1 = customerChoiceNumber - 1;

                new Food(20, 735, foodw, foodh, RushAndCrush.Properties.Resources.whiteb);
                Food f2 = new Food(150, 735, foodw, foodh, RushAndCrush.Properties.Resources.brownb);
                Food f3 = new Food(280, 735, foodw, foodh, RushAndCrush.Properties.Resources.sesameb);
                Food f4 = new Food(410, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg1);
                Food f5 = new Food(540, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg2);
                Food f6 = new Food(670, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg3);
                int cr1;
                cr1 = r.Next(1, 10);
                if (cr1 == 1)
                {
                    Food f1 = new Food();
                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }
                if (cr1 == 1)
                {

                }










            }
            //level two deals with three choice#s
            //drinks option only starts at level 2
            else if (customerChoiceNumber == 4)
            {
                c1 = customerChoiceNumber - 2;

                c3 = r.Next(1, 3);
                if (c3 == 1)
                {

                }
                else if (c3 == 2)
                {

                }
            }
            else if (customerChoiceNumber == 5)
            {

            }
            else if (customerChoiceNumber == 6)
            {

            }
            //level three deals with three choice#s
            else if (customerChoiceNumber == 7)
            {

            }
            else if (customerChoiceNumber == 8)
            {

            }
            else if (customerChoiceNumber == 9)
            {

            }


            //your choices 

            Refresh();
        }

        //Reading the levels...will need to convert all of the levels stored in one file 
        public void loadLevel01()
        {
            //creating Xml reader file 
            XmlReader reader = XmlReader.Create("level01.xml", null);
            string moodspeed, number, choice1, choice2, quota;
            
            
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    moodspeed = reader.ReadString();

                    reader.ReadToFollowing("number");
                    number = reader.ReadString();

                    reader.ReadToFollowing("choice1");
                    choice1 = reader.ReadString();

                    reader.ReadToFollowing("choice2");
                    choice2 = reader.ReadString();

                    reader.ReadToFollowing("quota");
                    quota = reader.ReadString();

                    Levels level1 = new Levels(moodspeed, number, choice1, choice2, quota);

                    levels.Add(level1);
                }
            }

            reader.Close();
        }

        public void loadLevel02()
        {
            //creating Xml reader file 
            XmlReader reader = XmlReader.Create("level02.xml", null);
            string moodspeed, number, choice1, choice2, quota;


            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    moodspeed = reader.ReadString();

                    reader.ReadToNextSibling("moodSpeed");
                    number = reader.ReadString();

                    reader.ReadToNextSibling("number");
                    choice1 = reader.ReadString();

                    reader.ReadToNextSibling("choice1");
                    choice2 = reader.ReadString();

                    reader.ReadToNextSibling("choice2");
                    quota = reader.ReadString();

                    Levels level2 = new Levels(moodspeed, number, choice1, choice2, quota);

                    levels.Add(level2);
                }
            }

            reader.Close();
        }

        public void loadLevel03()
        {
            //creating Xml reader file 
            XmlReader reader = XmlReader.Create("level03.xml", null);
            string moodspeed, number, choice1, choice2, quota;


            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    moodspeed = reader.ReadString();

                    reader.ReadToNextSibling("moodSpeed");
                    number = reader.ReadString();

                    reader.ReadToNextSibling("number");
                    choice1 = reader.ReadString();

                    reader.ReadToNextSibling("choice1");
                    choice2 = reader.ReadString();

                    reader.ReadToNextSibling("choice2");
                    quota = reader.ReadString();

                    Levels level3 = new Levels(moodspeed, number, choice1, choice2, quota);

                    levels.Add(level3);
                }
            }

            reader.Close();
        }


        //Writing the scores 

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            Pen objectpen = new Pen(Color.Black, 10);
            //drawing the items in the game
            foreach (Object o in items)
            {
                objectbrush = new SolidBrush(o.colour);
                e.Graphics.FillRectangle(objectbrush, o.x, o.y, o.width, o.height);
            }

            objectpen = new Pen(chooser.colour, 10);
            e.Graphics.DrawRectangle(objectpen, chooser.x, chooser.y, chooser.width, chooser.height);
            
            objectbrush.Color = mood.colour;
            e.Graphics.FillRectangle(objectbrush, mood.levelX, mood.levelY, mood.levelLength, mood.levelHeight);
            e.Graphics.DrawRectangle(objectpen, mood.x, mood.y, mood.width, mood.height);

            objectpen.Color = speechbub.colour;
            e.Graphics.DrawEllipse(objectpen, speechbub.x, speechbub.y, speechbub.width, speechbub.height);



            //drawing the food in the game
            foreach (Food f in foods)
            {
                e.Graphics.DrawImage(f.pic, f.x, f.y, f.w, f.h);
                
            }
            foreach (Toppings t in toppings)
            {

                objectbrush.Color = t.c;
                e.Graphics.FillEllipse(objectbrush, t.x, t.y, t.w, t.h);
            }


            foreach (Drink d in drinks)
            {
                e.Graphics.DrawImage(d.pic, d.x, d.y, d.w, d.h);
            }

            //drawing the customers 
            foreach (Customers c in customers)
            {
                e.Graphics.DrawImage(c.pic, c.x, c.y, c.w, c.h);
            }
        }


    }
}
