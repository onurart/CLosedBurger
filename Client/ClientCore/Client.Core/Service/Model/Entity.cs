using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Core.Service.Model
{
    public abstract class Entity
    {
        public Entity() { }
        public Entity(string id) { Id = id; }
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDelete { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public DateTime? DeletedDate { get; set; }
    }
}
