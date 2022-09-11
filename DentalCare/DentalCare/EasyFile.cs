
using System.Collections.Generic;
using System.IO;

namespace Util
{
	public delegate T LoadDataCallback<T>(string[] tokens) where T : class;
	public delegate List<string> SaveDataCallback<T>(T item) where T : class;

	public static class EasyFile<T> where T : class
	{
		public static List<T> LoadDataFromFile(string fileName, LoadDataCallback<T> callback)
		{
			List<T> data = new List<T>();

			using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
			using (StreamReader sr = new StreamReader(fs))
			{
				while (!sr.EndOfStream)
				{
					data.Add(callback(sr.ReadLine().Split('|')));
				}

				sr.Close();
				fs.Close();
			}

			return data;
		}

		public static void SaveDataToFile(string fileName, string[] properties, List<T> data)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.Create))
			using (StreamWriter sw = new StreamWriter(fs))
			{
				bool firstItem = true;
				foreach (T item in data)
				{
					if (!firstItem)
					{
						sw.WriteLine();
					}
					firstItem = false;

					bool firstProperty = true;
					foreach (string propertyName in properties)
					{
						if (!firstProperty)
						{
							sw.Write("|");
						}
						firstProperty = false;

						sw.Write(item.GetType().GetProperty(propertyName).GetValue(item));
					}
				}

				sw.Close();
				fs.Close();
			}
		}

		public static void SaveDataToFile(string fileName, List<T> data, SaveDataCallback<T> callback)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.Create))
			using (StreamWriter sw = new StreamWriter(fs))
			{
				bool firstItem = true;
				foreach (T item in data)
				{
					if (!firstItem)
					{
						sw.WriteLine();
					}
					firstItem = false;

					bool firstValue = true;
					foreach (string value in callback(item))
					{
						if (!firstValue)
						{
							sw.Write("|");
						}
						firstValue = false;

						sw.Write(value);
					}
				}

				sw.Close();
				fs.Close();
			}
		}
	}
}
