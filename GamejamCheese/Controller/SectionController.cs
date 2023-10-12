﻿using GamejamCheese.Models;
using GamejamCheese.View;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
    public static class SectionController
    {
        public static void StartSection(Section section)
        {
            HandleChoices(SectionView.ShowAndReturnChoice(section), section);
        }

        private static void HandleChoices(int choice, Section section)
        {
            switch (choice)
            {
                case 1:
                    //Implement section choice
                    for (int i = 0; i < 100; i++)
                    {
                        string temp = SearchSection();
                        Console.WriteLine(temp);
                    }
                    break;
                case 2:

                    break;
                case 3:
                    AnsiConsole.Clear();
                    StartSection(section.Connections[0].NextSection);
                    break;
                case 4:
                    break;
            }
        }
        private static string SearchSection()
        {
            string result = string.Empty;
            Random random = new Random();
            int randomnumber = random.Next(0, 5);
            bool isFound = true;

            switch (randomnumber)
            {

                case 0:
                    while (isFound)
                    {
                        int randomNumber = random.Next(0, DataController.Items.Count);
                        var randomItem = DataController.Items[randomNumber];

                        if (randomItem.ItemType == TypeOfItem.Junk)
                        {
                            Player.PlayerInventory.Append(randomItem);
                            isFound = false;
                            result = $"You got this item: {randomItem.Name}";
                        }
                    }
                    break;
                case 1:
                    while (isFound)
                    {
                        int randomNumber = random.Next(0, DataController.Items.Count);
                        var randomItem = DataController.Items[randomNumber];

                        if (randomItem.ItemType == TypeOfItem.Consumeble)
                        {
                            Player.PlayerInventory.Append(randomItem);
                            isFound = false;
                            result = $"You got this item: {randomItem.Name}";
                        }
                    }
                    break;
                case 2:
                    while (isFound)
                    {
                        int randomNumber = random.Next(0, DataController.Items.Count);
                        var randomItem = DataController.Items[randomNumber];

                        if (randomItem.ItemType == TypeOfItem.Gear)
                        {
                            Player.PlayerInventory.Append(randomItem);
                            isFound = false;
                            result = $"You got this item: {randomItem.Name}";
                        }
                    }
                    break;
                case 3:
                    int foundCoins = random.Next(1, 20);
                    Player.Coins += foundCoins;
                    result = $"You found {foundCoins} coins.\n Your new balance is {Player.Coins}";
                    break;
                case 4:
                    result = "You searched the area but found nothing.";
                    break;
            }
            return result;
        }
    }
}
