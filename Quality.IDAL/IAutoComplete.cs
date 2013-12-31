using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.IDAL
{
    public interface IAutoComplete
    {
        IList<string> GetAutoCompleteByType(string type);
        void AddAutoComplete(string name, string type);
       
    }
    
}
