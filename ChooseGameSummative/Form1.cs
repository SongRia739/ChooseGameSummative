﻿/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Media; 

namespace ChooseGameSummative
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        public Form1()
        {
            //display initial message and options
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.M)       //heart button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 99; }
                else if (scene == 6) { scene = 9; }
                else if (scene == 9) { scene = 14; }
                else if (scene == 14) { scene = 99; }
                else if (scene == 15) { scene = 18; }
                else if (scene == 18) { scene = 99; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 7; }
                else if (scene == 7) { scene = 13; }
                else if (scene == 12) { scene = 17; }
                else if (scene == 16) { scene = 22; }

            }
            else if (e.KeyCode == Keys.N) //star button press
            {
                if (scene == 6)
                {
                    int value = randGen.Next(1, 11);

                    if (value <= 3) { scene = 10; }
                    else { scene = 11; }
                }
                else if (scene == 11) { scene = 99; }
                else  if (scene == 0) { scene = 2; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 8) { scene = 99; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 12) { scene = 16; }
                else if (scene == 16) { scene = 23; }
                else if (scene == 23) { scene = 99; }
                else if (scene == 1) { scene = 0; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 15) { scene = 19; }

            }
            else if (e.KeyCode == Keys.Space) //diamond button press
            {
                if (scene == 15) { scene = 20; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21) { scene = 99; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0: 
                    textLabel.Text = "You just got of class at your 3rd year in university. Walking around campus, you notice 2 boys. Wchich one do you have a crush on? ";
                    heartLabel.Text = "Bang 'Christopher' Chan";
                    starLabel.Text = "Seo Changbin";
                    break;
                case 1:
                    textLabel.Text = "Bang 'Christopher' Chan- Very popular, extremely nice, friends with basically everyone on campus and a bussniss major. Do you like him?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No, not my type";
                    break;
                case 2:
                    textLabel.Text = "Seo Changbin- everyone knows him, bad boy persona, player, and is here on a sports scholarship. Do you like him?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No, not my type";
                    break;
                case 3:
                    textLabel.Text = "Chris notices you and quickly gathers up his things before jogging up to you. He asks if you're busy, are you?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No!";
                    break;
                case 4:
                    textLabel.Text = "You shyly approach him and ask if he want's to hang out with you. He scoffs but says yes anyway. Strange he agreed so fast but you think nothing of it. You hear whispers as the two of you get off campus. They call you his next use and throw lover. What do you do?";
                    heartLabel.Text = "Roll your eyes and glare at them ";
                    starLabel.Text = "Shamefully lower your head even though it isn't true";
                    break;
                case 5:
                    textLabel.Text = "You say yes and he laughs and bids a somewhat awkward goodbye, you lost your chance.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 6:
                    textLabel.Text = "His smile grows wider as he invites you out for lunch. You agree because duh, who wouldn't? The two of you walk off campus and end up between two shops. ";
                    heartLabel.Text = "The sushi place";
                    starLabel.Text = "McDonalds";
                    break;
                case 7:
                    textLabel.Text = "Changbin smirks and stands a little closer to you, the walking eventually leads you guys to a nearby park. He sits down by a nearby tree but he accidently sits on something spiky and lets out a girlish scream";
                    heartLabel.Text = "Pretend you didn't see anything";
                    starLabel.Text = "Laugh";
                    break;
                case 8:
                    textLabel.Text = "Changbin thinks you have no backbone and ditches you at the entrance ";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 9:
                    SoundPlayer player = new SoundPlayer(Properties.Resources.resturantChatterrr);
                    player.Play();
                    textLabel.Text = "He agrees and the two of you have a good time and you learn much more about eachother than you did before. The check finally comes, what do you do?";
                    heartLabel.Text = "Wait for Chris to pay for you";
                    starLabel.Text = "Immediately bring out your walet";
                    break;
                case 10:
                    textLabel.Text = "He agrees and the both of you have a simple conversation. Its going alright. Eventually, the check comes, what do you do?";
                    heartLabel.Text = "Wait for Chris to pay for you";
                    starLabel.Text = "Immediately bring out your walet";
                    break;
                case 11:
                    textLabel.Text = "He agrees and the both of you have a simple conversation. Things got awkward and you two parted ways early";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 12:
                    textLabel.Text = "He goes to glare at you but its immediately gone when he sees you smiling. You go and sit beside him, this wasn't what you exactly had in mind but it still works. Your bodies are oddly close and your heart is drumming in your chest";
                    heartLabel.Text = "Do nothing";
                    starLabel.Text = "Hold Changbin's hand";
                    break;
                case 13:
                    textLabel.Text = "He thinks you're mocking him and ends up cursing you out.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 14:
                    textLabel.Text = "The meal was expensive, he regrets asking you out to lunch";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 15:
                    textLabel.Text = "He kindly denies but you insist on paying for half. A faint blush decorates his cheeks. You two exit the place and he says it was fun, what's your next move?";
                    heartLabel.Text = "You give him a friendly hug";
                    starLabel.Text = "You ask for his number";
                    diamondLabel.Text = "You kiss him on the cheek";
                    break;
                case 16:
                    textLabel.Text = "You quietly interlace your fingers together and to your shock, he shyly squeezes your hand. 'This wasn't what I had in mind.' You mumble as he looks at you curiously. 'What did you have in mind then?'";
                    heartLabel.Text = "Kiss him";
                    starLabel.Text = "'I was thinking we could actually do something'";
                    diamondLabel.Text = "'Oh nothing, nevermind'";
                    break;
                case 17:
                    textLabel.Text = "You two sit in silence as other people walk by. The day ends quickly and you guys never speak again, what a nightmatr that was.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 18:
                    textLabel.Text = "He thinks he's been friendzoned, you two never meet again.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 19:
                    textLabel.Text = "He agrees and you two go on a few more outings. It doesn't go anywhere but the company was nice.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 20:
                    textLabel.Text = "He understands your affections clearly, the two of you eventually start dating.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 21:
                    textLabel.Text = "Changbin shrugs as you two go back to sitting in silence. You chickened out";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 22:
                    textLabel.Text = "You lean over and kiss the corner of his mouth. Changbin's face turned a dark shade of red, what a strange start to the relationship";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;
                case 23:
                    textLabel.Text = "Changbin frowns. Did you not like hanging out with him? You unintentionally left a bad impression";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    break;

                case 99:
                    textLabel.Text = "Play again?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No";
                    break;
                default:
                    break;
            }
        }
    }

}
