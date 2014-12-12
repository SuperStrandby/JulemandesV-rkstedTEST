using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulemandensVærksted
{
    public class JuleNisse : JuleAnsat
    {
        public string _name;
        public int _age;
        public string _workSpace;

        public override void CheckAge(int age)
        {
            if (age <= 199)
                throw new ArgumentException("JuleNissen er altid over 200 år gammel");
        }

        public JuleNisse(string name, int age, string workSpace)
        {
            _name = name;
            _workSpace = workSpace;
            _age = age;
        }

       
    }
}
