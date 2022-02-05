using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFdz0506.Model
{
    [Table(Name = "NewNotes")]
    public class NewNotes : INotifyPropertyChanged
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public bool isPerform { get; set; }
        [Column]
        public int CategoryId { get; set; }
        [Column]
        public string description { get; set; }
        [Column]
        public DateTime CreatDateTime { get; set; } = DateTime.Now;
        // public object SelectedNotes { get; }
        public bool _isPerform
        {
            get { return isPerform; }
            set
            {
                isPerform = value;
                OnPropertyChanged("isPerform");
            }
        }
        public string _description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("description");
            }
        }


        public NewNotes(int id, DateTime creatDateTime, bool Perform, int categoryId, string _description)
        {
            this.Id = id;
            this.CreatDateTime = creatDateTime;
            this.isPerform = Perform;
            this.CategoryId = categoryId;
            this.description = _description;
        }

        public NewNotes(NewNotes selectedNotes)
        {
            //this.Id= selectedNotes.Id;
           // this.CreatDateTime = selectedNotes.CreatDateTime;
            this.isPerform = selectedNotes.isPerform;
            //this.CategoryId = selectedNotes.CategoryId;
            this.description = selectedNotes.description;

        }

        public NewNotes()
        {
        }

        //public bool IsPerform
        //{
        //    get 
        //    { return isPerform; }
        //    set { isPerform = value; }
        //}
        //public int _CategoryId
        //{
        //    get { return CategoryId; }
        //    set { CategoryId = value; }
        //}
        //public string Description
        //{
        //    get { return description; }
        //    set { description = value; }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public override string ToString()
        {
            return $"Id: {Id}\tДата: {CreatDateTime}\tВыполнение: {isPerform} \tОписание: {description}";
        }
    }
}
