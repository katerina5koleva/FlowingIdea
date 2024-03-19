using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class WorkIdea : Idea
    {
        private string textOfWorkIdea;


        public override string TextOfIdea
        {
            get
            {
                return textOfWorkIdea;
            }
            set
            {
                if (textOfWorkIdea.Length < 3)
                {
                    throw new ArgumentException("Your work idea should be longer!!!");
                }
                else if (textOfWorkIdea.Length > 400)
                {
                    throw new ArgumentException("Please, write a shorter work idea!");
                }
                else
                {
                    this.textOfWorkIdea = value;
                }
            }
        }
    }
}
