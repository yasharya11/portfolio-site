using System;
using System.Collections.Generic;
using System.Text;
using Portfolio.Core;
using System.Linq;

namespace Portfolio.Data
{
    public interface IClickData
    {
        IEnumerable<Click> GetClicksById(string id);
    }

    public class InMemoryClickData : IClickData
    {
        List<Click> clicks;

        public InMemoryClickData()
        {
            clicks = new List<Click>()
            {
                new Click {Id = "1", Edited = EditedStatus.edited },
                new Click {Id = "2", Edited = EditedStatus.untouched },
                new Click {Id = "3", Edited = EditedStatus.edited },
                new Click {Id = "4", Edited = EditedStatus.untouched },
                new Click {Id = "5", Edited = EditedStatus.edited },
                new Click {Id = "6", Edited = EditedStatus.untouched },
                new Click {Id = "7", Edited = EditedStatus.edited }
            };
        }
        public IEnumerable<Click> GetClicksById(string id)
        {
            return from c in clicks
                   where string.IsNullOrEmpty(id) || c.Id.StartsWith(id)
                   orderby c.Id
                   select c;
        }
    }
}
