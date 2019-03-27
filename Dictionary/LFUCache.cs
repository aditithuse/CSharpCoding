public class LFUCache
    {
        public int Capacity;
        public int min = 0;
        
        Dictionary<int, LinkedListNode<CacheItem>> cache = new Dictionary<int, LinkedListNode<CacheItem>>();
        Dictionary<int, LinkedList<CacheItem>> freqlist = new Dictionary<int, LinkedList<CacheItem>>();
        public LFUCache(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Get(int key)
        {
            if (Capacity <= 0) return -1;
            if (!this.cache.ContainsKey(key)) return -1;

            var item = this.cache[key];
            // remove item from freq list;
            freqlist[item.Value.Count].Remove(item);
            // add item to freq list
            item.Value.Count++;
            if (!freqlist.ContainsKey(item.Value.Count)) {
                freqlist[item.Value.Count] = new LinkedList<CacheItem>();
            }
            freqlist[item.Value.Count].AddLast(item);

            if(freqlist[min].Count == 0)
            {
                min++;
            }
            return item.Value.Value;
        }

        public void Put(int key, int value)
        {
            if (this.Capacity <= 0) return;

            var item = this.Get(key);
            if(item != -1)
            {
                // count already updated
                this.cache[key].Value.Value = value;
                return;
            }

            if(cache.Count == this.Capacity)
            {
                // remove invalid node
                var expired = this.freqlist[min].First;
                this.cache.Remove(expired.Value.Key);
                this.freqlist[min].RemoveFirst();
            }
            //insert
            var newItem = new CacheItem { Key = key, Value = value, Count = 1 };
            if (!this.freqlist.ContainsKey(1)) this.freqlist[1] = new LinkedList<CacheItem>();
            var newNode = this.freqlist[1].AddLast(newItem);
            this.cache.Add(key, newNode);
            min = 1;
        }

        public class CacheItem
        {
            public int Value;
            public int Key;
            public int Count;
        }
    }
