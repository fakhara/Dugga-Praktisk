using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public interface IMediaItem
    {
        string Title { get; set; }
        int Rating { get; set; }
    }
}
