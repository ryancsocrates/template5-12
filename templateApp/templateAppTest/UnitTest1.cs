using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using templateClassNamespace;

namespace templateAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void can_add_variable_and_return_key_and_name()
        {
            // create variable/key
            // make user input the name of those keys
            // return result
            // prompt to add?

            // result = string (var name)

            //string var; // ${name}
            //string var_value; // put in the var

            //string template = "Happy Birthday, ${name}";
            string result;

            TemplateClass tc = new TemplateClass();
            result = tc.add_variable();
            Assert.AreEqual(result, "");
                        
        }
    }
}
