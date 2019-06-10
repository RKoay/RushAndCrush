using System;
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
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, spaceDown, enterDown, escDown;
        List<Object> items = new List<Object>();
        List<Food> foods = new List<Food>();
        List<Drink> drinks = new List<Drink>();
        List<Toppings> toppings = new List<Toppings>();
        List<Customers> customers = new List<Customers>();

        //Relating to Levels
        List<Levels> levels = new List<Levels>();
        int levelNumber;
        int moodspeeds;
        int numbers;
        int choice1s;
        int choice2s;
        double quotas;


        //creating mood level 
        MoodLevel mood;
        Object chooser;

        //creating speech bubbles
        Object speechbub = new Object(650, 10, 550, 540, Color.Black);
        int speechfoodw = 80;
        int speechfoodh = 80;

        //customers choice 
        List<Food> custochoice1 = new List<Food>();
        List<Toppings> custochoice2 = new List<Toppings>();
        List<Drink> custochoice3 = new List<Drink>();
        //generating the amount of items the customers want, 
        int customerChoiceNumber;


        //your choice
        List<Food> yourchoice1 = new List<Food>();
        List<Toppings> yourchoice2 = new List<Toppings>();
        List<Drink> yourchoice3 = new List<Drink>();

        SolidBrush objectbrush = new SolidBrush(Color.Wheat);

        int customerNumber = 0;

        int customerselector;

        //to calculate and display earnings
        double earnings  = 0;

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
            levelNumber = 1;
            loadLevel01();
            loadLevel02();
            loadLevel03();
            gameTimer.Enabled = true;
            
            OnStart();
            
            
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
                case Keys.Space:
                    spaceDown = true;
                    foreach (Food f in foods)
                    {
                        if (chooser.x == f.x && chooser.y == f.y)
                        {
                            //adding your choices to here 
                            yourchoice1.Add(f);
                            
                        }

                    }
                    foreach (Toppings t in toppings)
                    {
                        if (chooser.x == t.x && chooser.y == t.y)
                        {
                            yourchoice2.Add(t);
                        }
                    }
                    break;
                case Keys.Enter:
                    enterDown = true;
                    if (custochoice1.Count() == yourchoice1.Count())
                    {
                        foreach (Food f in custochoice1)
                        {
                            if (yourchoice1.Any(item => item.type == f.type))
                            {
                                mood.UpMood(50);
                            }
                            else
                            {
                                mood.DownMood(30);
                            }
                        }
                    }
                    else
                    {
                        mood.DownMood(30);
                    }

                    if (custochoice2.Count() == yourchoice2.Count())
                    {
                        foreach (Toppings t in custochoice2)
                        {
                            if (yourchoice2.Any(item => item.type == t.type))
                            {
                                mood.UpMood(20);
                            }
                            else
                            {
                                mood.DownMood(10);
                            }

                        }
                    }
                    else
                    {
                        mood.DownMood(10);
                    }
                    gameTimer.Enabled = false;
                    TimerOff();
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
                case Keys.Space:
                    spaceDown = false;
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
            switch (levelNumber)
            {
                case 1:
                    moodspeeds = Convert.ToInt16(levels[0].moodspeed);
                    numbers = Convert.ToInt16(levels[0].custonumber);
                    choice1s = Convert.ToInt16(levels[0].choiceone);
                    choice2s = Convert.ToInt16(levels[0].choicetwo);
                    quotas = Convert.ToDouble(levels[0].quota);
                    break;
                case 2:
                    moodspeeds = Convert.ToInt16(levels[1].moodspeed);
                    numbers = Convert.ToInt16(levels[1].custonumber); //apparently not in the correct format
                    choice1s = Convert.ToInt16(levels[1].choiceone);
                    choice2s = Convert.ToInt16(levels[1].choicetwo);
                    quotas = Convert.ToDouble(levels[1].quota);
                    break;
                case 3:
                    moodspeeds = Convert.ToInt16(levels[2].moodspeed);
                    numbers = Convert.ToInt16(levels[2].custonumber);
                    choice1s = Convert.ToInt16(levels[2].choiceone);
                    choice2s = Convert.ToInt16(levels[2].choicetwo);
                    quotas = Convert.ToDouble(levels[2].quota);
                    break;
            }

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
            Food f1 = new Food(20, 735, foodw, foodh, RushAndCrush.Properties.Resources.whiteb, "white");
            Food f2 = new Food(150, 735, foodw, foodh, RushAndCrush.Properties.Resources.brownb, "brown");
            Food f3 = new Food(280, 735, foodw, foodh, RushAndCrush.Properties.Resources.sesameb, "sesame");
            Food f4 = new Food(410, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg1, "veg1");
            Food f5 = new Food(540, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg2, "veg2");
            Food f6 = new Food(670, 735, foodw, foodh, RushAndCrush.Properties.Resources.veg3, "veg3");
            Toppings t7 = new Toppings(20, 917, foodw, foodh, Color.Brown, "brown");
            Toppings t8 = new Toppings(150, 917, foodw, foodh, Color.Red, "red");
            Toppings t9 = new Toppings(280, 917, foodw, foodh, Color.Yellow, "yellow");
            Food f10 = new Food(410, 917, foodw, foodh, RushAndCrush.Properties.Resources.meat1, "meat1");
            Food f11 = new Food(540, 917, foodw, foodh, RushAndCrush.Properties.Resources.meat2, "meat2");
            Food f12 = new Food(670, 917, foodw, foodh, RushAndCrush.Properties.Resources.meat3, "meat3");
            Drink dr1 = new Drink(holderx + (holderw - drinkw) / 2, holdery + (holderh - drinkh - drinkh) / 3, drinkw, drinkh, RushAndCrush.Properties.Resources.strawberryd);
            Drink dr2 = new Drink(holderx + (holderw - drinkw) / 2, holdery + (holderh - drinkh - drinkh) / 3 + drinkh + (holderh - drinkh - drinkh) / 3, drinkw, drinkh, RushAndCrush.Properties.Resources.chocolated);

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

            CustoCreater();

            mood = new MoodLevel(500, 100, 100, 400, 500, 300, 100, 200, Color.Yellow);
            

            //customers' choices that are randomized
            customerChoiceNumber = r.Next(choice1s, choice2s);

            //level one only deals with one choice#
            if (customerChoiceNumber == 3)
            {
                //all of these supposedly show up in speech bubbles 
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice2();

            }
            //level two deals with three choice#s
            //drinks option only starts at level 2
            else if (customerChoiceNumber == 4)
            {
                //all of these supposedly show up in speech bubbles 
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 90);
                GeneratingCustomerChoice2();
                GeneratingCustomerChoice3();
            }
            else if (customerChoiceNumber == 5)
            {
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 90);
                GeneratingCustomerChoice1(0, 90);
                GeneratingCustomerChoice2();
                GeneratingCustomerChoice3();
            }
            else if (customerChoiceNumber == 6)
            {
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 90);
                GeneratingCustomerChoice1(0, 90);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 90);
                GeneratingCustomerChoice2();
                GeneratingCustomerChoice3();
            }
            //level three deals with three choice#s
            else if (customerChoiceNumber == 7)
            {
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 90);
                GeneratingCustomerChoice1(0, 90);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 90);
                GeneratingCustomerChoice1(speechfoodw + 10, 180);
                GeneratingCustomerChoice2();
                GeneratingCustomerChoice3();
            }
            else if (customerChoiceNumber == 8)
            {
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 90);
                GeneratingCustomerChoice1(0, 90);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 90);
                GeneratingCustomerChoice1(speechfoodw + 10, 180);
                GeneratingCustomerChoice1(0, 180);
                GeneratingCustomerChoice2();
                GeneratingCustomerChoice3();
            }
            else if (customerChoiceNumber == 9)
            {
                GeneratingCustomerChoice1(0, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 0);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 0);
                GeneratingCustomerChoice1(speechfoodw + 10, 90);
                GeneratingCustomerChoice1(0, 90);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 90);
                GeneratingCustomerChoice1(speechfoodw + 10, 180);
                GeneratingCustomerChoice1(0, 180);
                GeneratingCustomerChoice1(speechfoodw + 20 + speechfoodw, 180);
                GeneratingCustomerChoice2();
                GeneratingCustomerChoice3();
            }


        }
        
        public void CustoCreater()
        {
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
            //Adding a customer to the number to keep track of the numbers of customers
            customerNumber++;
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //for (int i = 10; i >= 0; i--)
            //{
            //    outputLabel.Text += "\n" + i;
            //}

            
            //for every customer in the list,

            foreach (Customers c in customers)
            {
                //moving the customers towards the counter
                c.CustoMove();


                if (c.x < 0) { c.x = 0; }
                if (c.y < 100) { c.y = 100; }
                if (c.h > 475) { c.h = 475; }
                if (c.w > 480) { c.w = 480; }

            }

            //starting the level
            mood.StartLevel(moodspeeds);

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

            //if food is right or wrong, add the rightful amount of money
            if (mood.levelY == mood.height + mood.y)
            {
                gameTimer.Enabled = false;
                TimerOff();
            }
            
            Refresh();
        }

        
        public void TimerOff()
        {
            //mood.levelHeight/mood.height times 20
            earnings += ((double)mood.levelHeight / (double)mood.height) * 20;
            moneyEarned.Text = "$ " + earnings;
            
            //if customer number is smaller than the amount of customers in each level, proceed with the level
            if (customerNumber < numbers)
            {
                customers.RemoveAt(0);
                OnStart();
                gameTimer.Enabled = true;
            }
            //if the amount of customers is equal to the amount of customers in each level, display the code
            else if (customerNumber == numbers)
            {
                if (earnings >= quotas)
                {
                    levelNumber++;
                    customers.RemoveAt(0);
                    OnStart();
                    gameTimer.Enabled = true;
                }
                else
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(value: this);
                    GameOverScreen gos = new GameOverScreen();
                    f.Controls.Add(gos);

                    gos.Location = new Point((f.Width - gos.Width) / 2, (f.Height - gos.Height) / 2);
                    gos.Focus();
                }
            }

        }


        public void GeneratingCustomerChoice1(int movex, int movey)
        {
            int cr1;
            cr1 = r.Next(1, 10);

            if (cr1 == 1)
            {
                Food f1 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.whiteb, "white");
                custochoice1.Add(f1);

            }
            else if (cr1 == 2)
            {
                Food f2 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.brownb, "brown");
                custochoice1.Add(f2);

            }
            else if (cr1 == 3)
            {
                Food f3 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.sesameb, "sesame");
                custochoice1.Add(f3);
            }
            else if (cr1 == 4)
            {
                Food f4 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.veg1, "veg1");
                custochoice1.Add(f4);
            }
            if (cr1 == 5)
            {
                Food f5 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.veg2, "veg2");
                custochoice1.Add(f5);
            }
            if (cr1 == 6)
            {
                Food f6 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.veg3, "veg3");
                custochoice1.Add(f6);
            }
            if (cr1 == 7)
            {
                Food f7 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.meat1, "meat1");
                custochoice1.Add(f7);
            }
            if (cr1 == 8)
            {
                Food f8 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.meat2, "meat2");
                custochoice1.Add(f8);
            }
            if (cr1 == 9)
            {
                Food f9 = new Food(780 + movex, 140 + movey, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.meat3, "meat3");
                custochoice1.Add(f9);
            }

        }

        public void GeneratingCustomerChoice2()
        {
            int c2 = r.Next(1, 4);

            if (c2 == 1)
            {
                Toppings to = new Toppings(870, 50, speechfoodw, speechfoodh, Color.Brown, "brown");
                custochoice2.Add(to);

            }
            else if (c2 == 2)
            {
                Toppings tt = new Toppings(870, 50, speechfoodw, speechfoodh, Color.Red, "red");
                custochoice2.Add(tt);
            }
            else if (c2 == 3)
            {
                Toppings tth = new Toppings(870, 50, speechfoodw, speechfoodh, Color.Yellow, "yellow");
                custochoice2.Add(tth);
            }
        }

        public void GeneratingCustomerChoice3()
        {
            int c3 = r.Next(1, 3);
            if (c3 == 1)
            {
                Drink dr1 = new Drink(90 - speechfoodw/2, 410, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.chocolated);
                custochoice3.Add(dr1);

            }
            else if (c3 == 2)
            {
                Drink dr2 = new Drink(90 - speechfoodw/2, 410, speechfoodw, speechfoodh, RushAndCrush.Properties.Resources.strawberryd);
                custochoice3.Add(dr2);
            }
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

                    reader.ReadToFollowing("number");
                    number = reader.ReadString();

                    reader.ReadToFollowing("choice1");
                    choice1 = reader.ReadString();

                    reader.ReadToFollowing("choice2");
                    choice2 = reader.ReadString();

                    reader.ReadToFollowing("quota");
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

                    reader.ReadToFollowing("number");
                    number = reader.ReadString();

                    reader.ReadToFollowing("choice1");
                    choice1 = reader.ReadString();

                    reader.ReadToFollowing("choice2");
                    choice2 = reader.ReadString();

                    reader.ReadToFollowing("quota");
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
            objectbrush.Color = Color.White;
            e.Graphics.FillEllipse(objectbrush, speechbub.x, speechbub.y, speechbub.width, speechbub.height);
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

            foreach (Food f in custochoice1)
            {
                e.Graphics.DrawImage(f.pic, f.x, f.y, f.w, f.h);
            }

            foreach (Toppings t in custochoice2)
            {
                objectbrush.Color = t.c;
                e.Graphics.FillEllipse(objectbrush, t.x, t.y, t.w, t.h);
            }

            foreach (Drink d in custochoice3)
            {
                e.Graphics.DrawImage(d.pic, d.x, d.y, d.w, d.h);
            }
        }


    }
}
