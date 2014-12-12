using System;
using JulemandensVærksted;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JulemandensVærkstedTests
{
    [TestClass]
    public class JuleNisseTests
    {
        [TestMethod]
        public void TestAge()
        {
            JuleNisse julenisse = new JuleNisse("Per", 300, "Dukkeværksted");
            Assert.AreEqual("Per", julenisse._name);
            Assert.AreEqual(300, julenisse._age);
            Assert.AreEqual("Dukkeværksted", julenisse._workSpace);
        }

        [TestMethod()]
        
        public void TestAgeException()
        {
            JuleNisse julenisse2 = new JuleNisse("Bent", 150, "Dukkeværksted");

            try
            {
                julenisse2.CheckAge(150);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("JuleNissen er altid over 200 år gammel", e.Message);
            }
            
        }
    }
}
