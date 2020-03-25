using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_OgameLike
{
    public class FunctionBuilding : Building
    {
        public override int? CellNb()
        {
            throw new NotImplementedException();
        }

        public List<string> Actions (string Action)
        {
            List<string> listActions = new List<string>();
            listActions.Add(Action);
            return listActions;
        }
    }
}
