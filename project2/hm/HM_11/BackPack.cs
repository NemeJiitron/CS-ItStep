using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_11
{
    internal class Backpack
    {
        private string color;
        public string Color { get { return color; } 
            set {
                color = value;
                OnVarChanged();
            }
        }
        private string brand;
        public string Brand { get { return brand; } set 
            {
                brand = value;
                OnVarChanged();
            } 
        }
        private string material;
        public string Material
        {
            get { return material; }
            set
            {
                material = value;
                OnVarChanged();
            }
        }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnVarChanged();
            }
        }
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                OnVarChanged();
            }
        }
        public List<object> Items { get; private set; }

        public event Action<object> OnItemAdded;
        public event Action<object> OnItemRemoved;
        public event Action OnVarChanged;

        public Backpack(string color, string brand, string material, int weight, int volume)
        {
            this.color = color;
            this.brand = brand;
            this.material = material;
            this.weight = weight;
            this.volume = volume;
            Items = new List<object>();
        }

        public void AddItem(object item)
        {
            Items.Add(item);
            if (Items.Count > Volume)
            {
                throw new Exception("Backpack overloaded");
            }
            OnItemAdded?.Invoke(item);
        }
        public void RemoveItem(object item)
        {
            Items.Remove(item);
            OnItemRemoved?.Invoke(item);
        }
    }
}
