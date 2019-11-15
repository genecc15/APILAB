using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIS.Models
{
    public class Pizza
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string PizzaName { get; set; }

        public string Description { get; set; }

        public string[] Ingredients { get; set; }

        public string Dough { get; set; }

        public string Size { get; set; }

        public int Portions { get; set; }

        public bool hasCheese { get; set; }
    }
}
