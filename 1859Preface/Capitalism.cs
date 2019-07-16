using System;
using System.Collections.Generic;
using System.Text;

namespace _1859Preface
{
    public class Capitalism : Class, Exploite
    {
        private Classes.Capitalists _capitalist;
        public Classes.Capitalists Capitalist
        {
            set { _capitalist = value; }
        }
        private Classes.Labors _labor;
        public Classes.Labors Labor
        {
            set { _labor = value; }
        }

        public Capitalism()
        {
            _capitalist = new Classes.Capitalists();
            _labor = new Classes.Labors();
        }

        public Capitalism(Classes.Capitalists cap, Classes.Labors lb)
        {
            _capitalist = cap;
            _labor = lb;
        }

        public void Exploite()
        {

        }
    }
}
