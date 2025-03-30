using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ClassWork.CW.cw10;

namespace ClassWork.CW.cw13
{
    [Serializable]
    public class SerializablePerson
    {
        private int _id;
        public int Id => _id;

        public string Name { get; set; }
        public int Age { get; set; }

        public SerializablePerson() { }

        public SerializablePerson(int id)
        {
            _id = id;
        }

        [NonSerialized]
        const string Planet = "Earth";

        public override string ToString()
        {
            return $"{_id} {Name} {Age} {Planet}";
        }
    }

}
