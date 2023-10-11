using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
	public class Item
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Value { get; set; }
		public TypeOfItem ItemType { get; set; }
		public SlotType SlotType { get; set; }
		public ItemEffect? ItemEffect { get; set; }	

		//Constructor for normal items
		public Item(TypeOfItem itemType, string name, string discription, int value, ItemEffect? itemEffect)
		{
			ItemType = itemType;
			Name = name;
			Description = discription;
			Value = value;
			ItemEffect = itemEffect;
			ItemEffect = itemEffect;
		}

		//Constructor for gear
		public Item(string name, string discription, int value, ItemEffect itemEffect, SlotType slotType)
		{
			Name = name;
			Description = discription;
			Value = value;
			ItemType = TypeOfItem.Gear;
			ItemEffect = itemEffect;
			SlotType = slotType;
		}

	}
	public enum TypeOfItem
	{
		Consumeble,
		Gear,
		QuestItem,
		Junk
	}
	public enum ItemEffect
	{
		IncreaseO2,
		IncreaseHP,
		IncreaseBaseDamage,
		HealAmountHP,
		RestoreAmountO2,
		RestoreFuel,
		LessO2MoreDamage,
		LessFuelMoreHP
	}
	public enum SlotType
	{
		Pants,
		Chest,
		Shoes,
		Weapon,
		Helmet
	}
}
