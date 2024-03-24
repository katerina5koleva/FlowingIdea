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
        public int Id { get; private set; }
        public int IdeaType { get; private set; }
        [ForeignKey(nameof(User.Id))]
        public int UserId { get; private set; }

        public string textOfIdea;
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
