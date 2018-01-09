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

		[DataMember]
		public List<Category> Categories;

		[DataMember]
		public List<Item> Items;

		public Inventory()
		{
			Categories = new List<Category>() { new Category(0, "Mech"), new Category(1, "Elec"),
				new Category(2, "Code"), new Category(3, "Bump"), new Category(4, "Misc"), new Category(5, "Part") };
			Items = new List<Item>();
		}

		public bool TryAddCategory(string name)
		{
			List<int> ids = new List<int>(Categories.Count);
			foreach (Category category in Categories)
				if (category.Name == name)
					return false;
				else
					ids.Add(category.Id);

			for (int i = 0; i <= Categories.Count; i++)
			{
				if (!ids.Contains(i))
				{
					Categories.Add(new Category(i, name));
					break;
				}
			}

			return true;
		}


		public bool TryRenameCategory(Category cat, string newName, bool force = false)
		{
			if (cat.Name == newName)
				return true;

			foreach (Category category in Categories)
			{
				if (category.Name == newName)
				{
					if (force)
					{
						RemoveCategory(cat);
						foreach (Item item in Items)
							item.Cat = category;
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

		public Category FindCategoryById(int value)
		{
			foreach (Category cat in Categories)
				if (cat.Id == value)
					return cat;
			return Category.NONE;
		}

		public Category FindCategoryByName(string s)
		{
			foreach (Category cat in Categories)
				if (cat.Name == s)
					return cat;
			return Category.NONE;
		}

		public void RemoveCategory(Category categoryValue)
		{
			foreach (Item item in Items)
			{
				if (item.Cat.Equals(categoryValue))
				{
					item.Cat = Category.NONE;
				}
			}

			for (int i = 0; i < Categories.Count; i++)
			{
				if (Categories[i].Equals(categoryValue))
				{
					Categories.Remove(Categories[i]);
					break;
				}
			}
		}

		public void CorrectItemErrors()
		{
			foreach (Item item in Items)
			{
				item.Cat = FindCategoryById(item.Cat.Id);
			}
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
