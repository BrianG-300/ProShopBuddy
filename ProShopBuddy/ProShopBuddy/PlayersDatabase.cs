using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SQLite;

namespace ProShopBuddy
{
	public class PlayerDatabase
	{
		readonly SQLiteAsyncConnection conn;
		public ObservableCollection<Players> p { get; set; }

		public PlayerDatabase(string dbPath)
		{
			conn = new SQLiteAsyncConnection(dbPath);
			conn.CreateTableAsync<Players>().Wait();
		}


		//Get All Database
		public Task<List<Players>> GetPlayersAsync()
		{
			return conn.Table<Players>().ToListAsync();
		}


		//Get Specific player based on NAME
		public Task<Players> GetPlayerAsync(int id)
		{
			return conn.Table<Players>().Where(i => i._ID == id).FirstOrDefaultAsync();
		}

		//Save player
		public Task<int> SavePlayerAsync(Players player)
		{
			if (player._ID == 0)
			{
				return conn.InsertAsync(player);
			}
			else
			{
				return conn.UpdateAsync(player);
			}
		}

		//Delete player
		public Task<int> DeletePlayerAsync(Players player)
		{
			return conn.DeleteAsync(player);
		}

	}
}
