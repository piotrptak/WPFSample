using Pptak.WPFSample.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.ViewModels
{
    public interface IMainViewModel
    {
        IList<Pupil> Pupils { get; set; }
    }
}
