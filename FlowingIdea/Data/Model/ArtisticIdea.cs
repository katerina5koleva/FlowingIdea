using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ArtisticIdea : Idea
    {
        [Key]
        public int Id { get; set; }
        public int ideaType;
        public int IdeaType
        {
            get
            {
                return this.ideaType;
            }
            set
            {
                this.ideaType = value;
            }
        }
        override public int UserId { get; set; }
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
        public ArtisticIdea()
        {
                
        }
        public ArtisticIdea(int userId, string textOfArtisticIdea)
        {
            this.IdeaType = 1;
            this.UserId = userId;
            this.TextOfIdea = textOfArtisticIdea;
        }
    }
}
