using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using templateClassNamespace;

namespace templateAppTest
{
    [TestClass]
    public class TemplateAppTest
    {
        [TestMethod]
        public void can_add_variable_and_return_key_and_name()
        {
            // create variable/key
            // make user input the name of those keys
            // return result
            // prompt to add?

            // result = string (var name)

            //string template = "Happy Birthday, ${name}";
            

            TemplateClass tc = new TemplateClass();
            string result = tc.add_var_and_var_value("age", "30");

            Assert.AreEqual(result, "30");                    
        }
    }
}
