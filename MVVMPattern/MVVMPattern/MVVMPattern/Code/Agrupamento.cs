using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.Code
{
    class Agrupamento<K,T> : ObservableCollection<T>
    {
        public K Chave { get; private set; }
        public Agrupamento(K chave, IEnumerable<T> items)
        {
            Chave = chave;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
