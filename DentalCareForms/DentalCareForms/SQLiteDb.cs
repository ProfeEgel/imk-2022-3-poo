using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
	public sealed partial class SQLiteConn : IDisposable
	{
		private sealed class SQLiteRecordSet : IDisposable
		{
			private SQLiteCommand cmd;
			private SQLiteDataReader dr;

			public SQLiteRecordSet(SQLiteConn conn, string query)
			{
				cmd = conn.conn.CreateCommand();
				cmd.CommandText = query;
				dr = cmd.ExecuteReader();
			}

			public bool NextRecord()
			{
				return dr.Read();
			}

			public string GetString(string column)
			{
				return dr.GetString(dr.GetOrdinal(column));
			}

			public int GetInt32(string column)
			{
				return dr.GetInt32(dr.GetOrdinal(column));
			}

			public long GetInt64(string column)
			{
				return dr.GetInt64(dr.GetOrdinal(column));
			}

			public double GetDouble(string column)
			{
				return dr.GetDouble(dr.GetOrdinal(column));
			}

			public bool IsNull(string column)
			{
				return dr.IsDBNull(dr.GetOrdinal(column));
			}

			public void Close()
			{
				dr.Close();
			}

			public void Dispose()
			{
				dr.Dispose();
				cmd.Dispose();
			}
		}

		private SQLiteConnection conn;

		public SQLiteConn(string databaseName, bool autoConnect = false)
		{
			conn = new SQLiteConnection(String.Format("Data Source='{0}'", databaseName));

			if (autoConnect == true)
			{
				conn.Open();
			}
		}

		private SQLiteRecordSet ExecuteQuery(string query)
		{
			return new SQLiteRecordSet(this, query);
		}

		public int ExecuteNonQuery(string commandText)
		{
			int rows = 0;

			using (SQLiteCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				rows = cmd.ExecuteNonQuery();
			}

			return rows;
		}

		public void Open()
		{
			conn.Open();
		}

		public void Close()
		{
			conn.Close();
		}

		public void Dispose()
		{
			conn.Dispose();
		}
	}
}
