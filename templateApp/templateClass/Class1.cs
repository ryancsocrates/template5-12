using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templateClassNamespace
{
    public class TemplateClass
    {

        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string add_var_and_var_value(string var, string var_value)
        {

            //ask user for var
            //ask user for var_value
            //put them into a dictionary
            //return those values when called on
            dictionary.Add(var, var_value);

            return dictionary[var];

        }
    }
}
