using SRIMS.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SRIMS
{
	public class CheckoutManager
	{
		public List<CheckedOutItem> CheckoutList;

		public CheckoutManager()
		{
			LoadData();
		}

		private void LoadData()
		{
			string s = Settings.Default.CheckoutList;

			if (!string.IsNullOrEmpty(s))
			{
				try
				{
					MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(s));
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<CheckedOutItem>));
					CheckoutList = (List<CheckedOutItem>)serializer.ReadObject(stream);
				}
				catch (Exception e)
				{
					Console.WriteLine("There Was An Error When Parsing Settings For CheckOutItems");
					Console.WriteLine(e);
					Settings.Default.CheckoutList = string.Empty;
					CheckoutList = new List<CheckedOutItem>();
				}
			}
			else
			{
				CheckoutList = new List<CheckedOutItem>();
			}
		}

		private void SaveData()
		{
			MemoryStream stream = new MemoryStream();
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<CheckedOutItem>));
			serializer.WriteObject(stream, CheckoutList);
			Settings.Default.CheckoutList = Encoding.UTF8.GetString(stream.ToArray());
			Settings.Default.Save();
		}

		public void CheckOutItem(CheckedOutItem item)
		{
			foreach (CheckedOutItem x in CheckoutList)
			{
				if (x.ItemId == item.ItemId && x.Name == item.Name)
				{
					x.Qt += item.Qt;
					return;
				}
			}

			CheckoutList.Add(item);
			SaveData();
		}

		public void CheckInItem(CheckedOutItem item, int quantity)
		{
			if (quantity == 0)
				return;

			if (quantity < item.Qt)
				item.Qt -= quantity;
			else
				CheckoutList.Remove(item);

			SaveData();
		}

		public void CheckInItem(CheckedOutItem item)
		{
			CheckInItem(item, item.Qt);
		}

		public int QuantityCheckedOut(Item item)
		{
			int total = 0;

			foreach (CheckedOutItem i in CheckoutList)
				if (i.ItemId == item.Id)
					total += i.Qt;

			return total;
		}
	}

	[DataContract]
	public class CheckedOutItem : IComparable<CheckedOutItem>
	{
		[DataMember]
		public string Name { get; set; } = "";
		[DataMember]
		public int Qt { get; set; } = 0;
		[DataMember]
		public int ItemId { get; set; } = -1;

		public CheckedOutItem(string name, Item x, int qt)
		{
			Name = name;
			ItemId = x.Id;
			Qt = qt;
		}

		public override string ToString()
		{
			Item item = SRIMSForm.Instance.Inv.FindItemById(ItemId);

			return $"{Name}: {item.Name} - {item.Loc} - Qt[{Qt}]";
		}

		public int CompareTo(CheckedOutItem other)
		{
			return ToString().CompareTo(other.ToString());
		}
	}
}
