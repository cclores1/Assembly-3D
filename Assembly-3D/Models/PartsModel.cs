using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Models
{
    public class PartsModel
    {
        [DisplayName("Id Number")]
        public int Id { get; set; }

        [DisplayName("Part Name")]
        public string Name { get; set; }

        [DisplayName("Part Description")]
        public string Description { get; set; }

        internal object GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
