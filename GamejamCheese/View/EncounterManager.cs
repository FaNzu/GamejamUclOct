using GamejamCheese.Models;
using GamejamCheese.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.View
{
	public class EncounterManager
	{
		Random random = new Random();

		// todo:
		// check kind of encounter ( friend or foe )
		// if vendor go to shopping menu
		// if enemy go to combat
		// loop.
			// --> Player chooses action from menu ( atk, flee, use item )
			// effects apply
			// damage apply
			// is enemy dead check?
			// if dead, drop loot
			// else Enemy action
			// player losses (hp,O2,fuel)
			// check if O2 and/or hp = 0
			// --> if true = GameOver
		// loop end
		// go to navigation ( overworld choices )

		
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
            //return ??

            // loop.
            // --> Player chooses action from menu ( atk, flee, use item )
            // effects apply
            // damage apply
            // is enemy dead check?
            // if dead, drop loot
            // else Enemy action
            // player losses (hp,O2,fuel)
            // check if O2 and/or hp = 0
            // --> if true = GameOver
            // loop end

            // --> Player chooses action from menu ( atk, flee, use item )
            Console.WriteLine
				(" choose action! \n" +
				" 1. atk \n" +
				" 2. use item \n" +
				" 3. flee" +
				" "
				);

			int Input = int.Parse(Console.ReadLine());

			switch (Input)
			{
				case 1: // atk with weapon
					int DiceRoll = random.Next(1,20);
					Console.WriteLine("you rolled a:"+DiceRoll);
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


            // damage apply



            // is enemy dead check?
				/*
				 * sudo:
				 * if enemy's hp <=0: end encounter
				 * else: enemies action ( dmg to hp,O2,Fuel )
				*/




            // if dead, drop loot
			 /*
			  * roll on the lootTable
			  * drop item
			  * if inventory is free, pickup
			  * else ask to swap item
			 */


			



        }
        public void MeetVendor() 
		{
			// show  shooping menu
			// player buys something
				// update inventory

		}

    }

}
