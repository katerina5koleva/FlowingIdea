using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class EditedIdea : Idea
    {
        [Key]
        public int Id { get; set; }
        override public int IdeaType { get; set; }
        [ForeignKey(nameof(User.Id))]
        override public int UserId { get; set; }
        private string textOfEditedIdea;

        public override string TextOfIdea
        {
            get
            {
                return textOfEditedIdea;
            }
            set
            {

                this.textOfEditedIdea = value;
            }
        }
    }
}
