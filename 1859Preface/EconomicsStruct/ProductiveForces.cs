using System;
using System.Collections.Generic;
using System.Text;

namespace _1859Preface
{
    public abstract class ProductiveForces : Production
    {
        private LevelOfProduction _level;
        public LevelOfProduction Level
        {
            get { return _level; }
        }
        public delegate void R_LevelUp();
        public abstract void LevelUp();
    }
}
