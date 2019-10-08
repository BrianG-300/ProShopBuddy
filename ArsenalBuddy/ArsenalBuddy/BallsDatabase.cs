using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SQLite;

namespace ArsenalBuddy
{
    public class BallsDatabase
    {
        readonly SQLiteAsyncConnection conn;
        public ObservableCollection<BowlingBalls> b { get; set; }

        public BallsDatabase(string dbPath)
        {
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<BowlingBalls>().Wait();
        }


        //Get All Database
        public Task<List<BowlingBalls>> GetBallsAsync()
        {
            return conn.Table<BowlingBalls>().ToListAsync();
        }


        //Get Specific player based on NAME
        public Task<BowlingBalls> GetBallAsync(int id)
        {
            return conn.Table<BowlingBalls>().Where(i => i._ID == id).FirstOrDefaultAsync();
        }

        //Save player
        public Task<int> SaveBallAsync(BowlingBalls b)
        {
            if (b._ID == 0)
            {
                return conn.InsertAsync(b);
            }
            else
            {
                return conn.UpdateAsync(b);
            }
        }

        //Delete player
        public Task<int> DeleteBallAsync(BowlingBalls b)
        {
            return conn.DeleteAsync(b);
        }


    }
}
