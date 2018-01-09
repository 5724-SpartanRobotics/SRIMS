using System.Collections.Generic;
using System.Text;

namespace SRIMS
{
	class CSVHelper
	{
		public static Item DeserializeItem(string itemLine)
		{
			string[] vals = LineToArray(itemLine);
			return new Item((int.Parse(vals[0])), vals[1], SRIMSForm.Instance.Inv.FindCategoryByName(vals[2]),
				vals[3], vals[4], int.Parse(vals[5]));
		}

		public static string SerializeItem(Item item)
		{
			return ArrayToLine(item.Id.ToString(), item.Loc, item.Cat.Name, item.Name, item.Desc, item.Qt.ToString());
		}

		// I'm using the rules excel does for escaping commas / quotes
		public static string[] LineToArray(string csvLine)
		{
			List<string> list = new List<string>();

			bool inQuotes = false;
			StringBuilder cell = new StringBuilder();

			int startQuotePos = 0;

			for (int i = 0; i < csvLine.Length; i++)
			{
				if (csvLine[i] == '"')
				{
					if (inQuotes)
					{
						if (i + 1 < csvLine.Length && csvLine[i + 1] == '"')
						{
							i++;
							cell.Append('\"');
						}
						else
						{
							inQuotes = false;
						}
					}
					else
					{
						inQuotes = true;
						startQuotePos = i;
					}
				}
				else if (csvLine[i] == ',' && !inQuotes)
				{
					list.Add(cell.ToString());
					cell.Clear();
				}
				else
				{
					cell.Append(csvLine[i]);
				}

			}

			// Invalid line, just ignore quotes
			if (inQuotes)
				return csvLine.Split(',');

			list.Add(cell.ToString());

			return list.ToArray();
		}

		public static string ArrayToLine(params string[] data)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < data.Length; i++)
			{
				if (data[i].Contains(",") || data[i].Contains("\""))
				{
					sb.Append("\"");
					sb.Append(data[i].Replace("\"", "\"\""));
					sb.Append("\"");
				}
				else
				{
					sb.Append(data[i]);
				}
				if (i < data.Length - 1)
					sb.Append(',');
			}

			return sb.ToString();
		}
	}
}
