using GamejamCheese.Data;
using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
    public class EncounterController
    {
        Random random = new Random();
        Encounter encounter = new Encounter(0, 12, 12, DataInitialiser.GenerateItems()[5]); // need to adjust item parameter

        // todo:
        // if vendor go to shopping menu
        // loop.
        // --> Player chooses action from menu ( atk, flee, use item )

        public Item? Encounter(EncounterType type) // todo add modifier
        {
            //if (type == EncounterType.Alien) 
            //{
            //	StartBattle();	
            //}
            //else
            //{
            //	// return ??
            //}

            switch (type)
            {
                case EncounterType.Alien:
                    Console.Write("helllo alien");
                    StartBattle();
                    break;
                case EncounterType.ArlaEmploye:
                    StartBattle();
                    break;

                case EncounterType.Vendor:
                    // open shopping menu
                    break;
            }
            return null;
        }
        public void StartBattle()
        {
            // loop. 
            // --> Player chooses action from menu ( atk, flee, use item ) Done ( missing item )
            // effects apply 
            // is enemy dead check? done
            // if dead, drop loot item missing
            // else Enemy action done
            // player losses (hp,O2,fuel) need to change
            // check if O2 and/or hp = 0
            // --> if true = GameOver
            // loop end

            // --> Player chooses action from menu ( atk, flee, use item )
            Console.WriteLine
                (" choose action! \n" +
                " 1. Shoot! \n" +
                " 2. use item \n" +
                " 3. flee" +
                " "
                );

            int Input = int.Parse(Console.ReadLine());

            switch (Input)
            {
                case 1: // atk with weapon
                    int DiceRoll = random.Next(1, 20);
                    Console.WriteLine("you rolled a:" + DiceRoll);
                    encounter.HP -= DiceRoll;
                    break;
                case 2: // use item in inventory

                    break;
                case 3: // try to flee ( dice roll? )
                    int FleeRoll = random.Next(1, 100);
                    Console.WriteLine("you rolled a:" + FleeRoll);
                    if (FleeRoll >= 50)
                    {
                        //end combat
                    }
                    break;
            }

            // effects apply
            // is enemy dead check?
            /*
             * sudo:
             * if enemy's hp <=0: end encounter
             * else: enemies action ( dmg to hp,O2,Fuel )
            */

            if (encounter.HP <=0)
            {
                // end encounter
                /*
                 * roll on the lootTable
                 * drop item
                 * if inventory is free, pickup
                 * else ask to swap item
                */
            }
            else
            {
                int EnemyRoll = random.Next(1, 10);
                Console.WriteLine("the enemy is attacking");
                Console.WriteLine("you take:" + EnemyRoll + " Damage!");
                Models.Player.HP -= EnemyRoll;

            }
        }
        public void MeetVendor() // needs lots
        {
            // show  shooping menu
            // player buys something
            // update inventory

        }

    }
}
