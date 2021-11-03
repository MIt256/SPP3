using InfoCollector.Models;
using InfoCollector.Models.CustomAssembly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;

using static InfoCollector.Models.InfoCollector;

namespace InfoCollectorTests
{
    [TestClass]
    public class InfoCollectorTests
    {
        [TestMethod]
        public void TestGettingNamespaces()
        {
            var assemblyInfo = LoadAssembly("ExampleLib.dll");
            var actual = assemblyInfo.AssemblyNamespaces[0].NamespaceName;
            var expected = "TestingNamespace";
            Assert.AreEqual(expected, actual);

            actual = assemblyInfo.AssemblyNamespaces[1].NamespaceName;
            expected = "ExampleLib";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingClassNames() 
        {
            var assemblyInfo = LoadAssembly("ExampleLib.dll");
            var actual = assemblyInfo.AssemblyNamespaces[1].NamespaceTypes[0].TypeName;
            var expected = "ExampleLib.Example3";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingMethodNames()
        {
            var assemblyInfo = LoadAssembly("ExampleLib.dll");
            var actual = assemblyInfo.AssemblyNamespaces[1].NamespaceTypes[2].MembersInfos[4].Description;
            var expected = "Method: Boolean One(System.Int32 a, System.String b)";
            Assert.AreEqual(expected, actual);
        }

         [TestMethod] 
        public void TestGettingPropertyNames()
        {
            var assemblyInfo = LoadAssembly("ExampleLib.dll");
            var actual = assemblyInfo.AssemblyNamespaces[1].NamespaceTypes[2].MembersInfos[1].Description;
            var expected = "Property: CoolProperty: System.Int32";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingFieldNames() 
        {
            var assemblyInfo = LoadAssembly("ExampleLib.dll");
            var actual = assemblyInfo.AssemblyNamespaces[1].NamespaceTypes[2].MembersInfos[0].Description;
            var expected = "Field: type: System.String";
            Assert.AreEqual(expected, actual);
        }
    }
}