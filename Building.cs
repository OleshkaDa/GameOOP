using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public abstract class Building : GameObject
    {
        private bool built;

        public Building(int objectId, string objectName)
            : base(objectId, objectName)
        {
            built = false;
        }

        public bool isBuilt()
        {
            return built;
        }

        public void build()
        {
            built = true;
        }

        public void destroy()
        {
            built = false;
        }
    }
}
