using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SRIMS
{
	[DataContract]
	public class Inventory
	{
		[DataMember]
		public readonly int DataVersion = 0;

		public Dictionary<int, Category> Categories;

		[DataMember(Name = "Categories")]
		private List<Category> _Categories
		{
			get
			{
				List<Category> ret = new List<Category>(Categories.Count);
				foreach (Category cat in Categories.Values)
					ret.Add(cat);
				return ret;
			}
			set
			{
				Categories = new Dictionary<int, Category>(value.Count);
				foreach (Category cat in value)
					Categories.Add(cat.Id, cat);

			}
		}

		public Dictionary<int, Item> Items;

		[DataMember(Name = "Items")]
		private List<Item> _Items
		{
			get
			{
				List<Item> ret = new List<Item>(Items.Count);
				foreach (Item item in Items.Values)
					ret.Add(item);
				return ret;
			}
			set
			{
				Items = new Dictionary<int, Item>(value.Count);
				foreach (Item item in value)
					Items.Add(item.Id, item);

			}
		}

		public void AddItem(Item item)
		{
			Items.Add(item.Id, item);
		}

		public void RemoveItem(Item item)
		{
			Items.Remove(item.Id);
		}

		public Inventory()
		{
			_Categories = new List<Category>() { new Category(0, "Mech"), new Category(1, "Elec"),
				new Category(2, "Code"), new Category(3, "Bump"), new Category(4, "Misc"), new Category(5, "Part") };
			Items = new Dictionary<int, Item>();
		}

		public bool TryAddCategory(string name)
		{
			List<int> ids = new List<int>(Categories.Count);
			foreach (Category category in Categories.Values)
				if (category.Name == name)
					return false;
				else
					ids.Add(category.Id);

			for (int i = 0; i <= Categories.Count; i++)
			{
				if (!ids.Contains(i))
				{
					Categories.Add(i, new Category(i, name));
					break;
				}
			}

			return true;
		}

		public bool TryRenameCategory(Category cat, string newName, bool force = false)
		{
			if (cat.Name == newName)
				return true;

			foreach (Category other in Categories.Values)
			{
				if (other.Name == newName)
				{
					if (force)
					{
						foreach (Item item in Items.Values)
							if (item.Cat.Equals(cat))
								item.Cat = other;

						RemoveCategory(cat);
						return true;
					}
					else
					{
						return false;
					}
				}
			}

			cat.Name = newName;
			return true;
		}

		public Item FindItemById(int value)
		{
			if (Items.TryGetValue(value, out Item ret))
				return ret;

			return Item.NONE;
		}

		public Category FindCategoryById(int value)
		{
			if (Categories.TryGetValue(value, out Category ret))
				return ret;

			return Category.NONE;
		}

		public Category FindCategoryByName(string s)
		{
			foreach (Category cat in Categories.Values)
				if (cat.Name == s)
					return cat;

			return Category.NONE;
		}

		public void RemoveCategory(Category categoryValue)
		{
			if (Categories.ContainsKey(categoryValue.Id))
			{
				foreach (Item item in Items.Values)
					if (item.Cat.Equals(categoryValue))
						item.Cat = Category.NONE;

				Categories.Remove(categoryValue.Id);
			}
		}

		public void CorrectItemErrors()
		{
			foreach (Item item in Items.Values)
				item.Cat = FindCategoryById(item.Cat.Id);
		}
	}

	[DataContract]
	public class Category
	{
		[DataMember]
		public int Id;

		[DataMember]
		public string Name;

		public static readonly Category NONE = new Category(-1, "");

		public Category(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public override string ToString()
		{
			return Name;
		}

		public override bool Equals(object obj)
		{
			if (obj is Category other)
				return other.Name == Name && other.Id == Id;
			return false;
		}

		public override int GetHashCode()
		{
			var hashCode = -1919740922;
			hashCode = hashCode * -1521134295 + Id.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
			return hashCode;
		}
	}
}
