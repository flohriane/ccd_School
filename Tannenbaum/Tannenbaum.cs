using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class Tannenbaum
    {
        private Model model;
        private View view;
        public Tannenbaum (Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void GetStarted()
        {
            view.GetNumberOfLines();
            view.GetStar();
            //model.MakeTannenbaum();
            view.PrintTannenbaum();
            view.EndProgramm();
        }

    }
}
