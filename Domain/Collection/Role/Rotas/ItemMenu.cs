using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Security.API.Domain.Json.Role.Rotas
{
    public class ItemMenuModel
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Title { get; set; }
        public int? Badge { get; set; }
        public List<ItemMenuModel> Items { get; set; }

    }
}
