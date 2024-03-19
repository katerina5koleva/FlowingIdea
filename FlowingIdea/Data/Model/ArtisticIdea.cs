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
                if (textOfArtisticIdea.Length < 3)
                {
                    throw new ArgumentException("Your art idea should be longer!!!");
                }
                else if (textOfArtisticIdea.Length > 400)
                {
                    throw new ArgumentException("Please, write a shorter artistic idea!!!");
                }
                else
                {
                    this.textOfArtisticIdea = value;
                }
            }
        }
    }
}
