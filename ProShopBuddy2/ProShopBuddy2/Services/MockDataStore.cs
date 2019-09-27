using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProShopBuddy;
using ProShopBuddy2.Models;

namespace ProShopBuddy2.Services
{
    public class MockDataStore : IDataStore<Players>
    {
        List<Players> items;

        public MockDataStore()
        {
            items = new List<Players>();
            var mockItems = new List<Players>
            {
                new Players {
                    TEXTNAME= "Joe Bloggs",
                    LFINREV= "1/4",
                    LFINLAT= "1/4",
                    LFINFOR= null,
                    LDRILL= "31/32",
                    RFINREV= "1/4",
                    RFINLAT= "3/8",
                    RFINFOR= null,
                    RDRILL= "31/32",
                    MIDINSERT= "7.5",
                    RINGINSERT="5",
                    LSPAN= "4 1/16",
                    RSPAN= "4 3/16",
                    THUMBREV= "1/8",
                    THUMBRLAT= null,
                    THUMBLLAT= "1/4",
                    THUMBFOR = null,
                    THUMBDRILL= "1 1/64",
                    PAP= "4 1/2 across and 3/4 up",
                    BRIDGE= "1/4",
                    NOTES= "Slug size 1 3/8 Oval Side Inserts",
                    EMAIL= "J.Bloggs@example.com",
                    BALLSPEED = "18",
                    REVRATE = "475",
                    AXISTILT = "15",
                    AXISROTATION = "35"
                }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Players item)
        {
            items.Add(item);


            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Players item)
        {
            var oldItem = items.Where((Players arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Players arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Players> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Players>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}