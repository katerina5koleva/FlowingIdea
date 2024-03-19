using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ArtisticIdea : Idea
    {
        private string textOfArtisticIdea;

        public override string TextOfIdea
        {
            get
            {
                return textOfArtisticIdea;
            }
            set
            {
               
              this.textOfArtisticIdea = value;
            }
        }
    }
}
