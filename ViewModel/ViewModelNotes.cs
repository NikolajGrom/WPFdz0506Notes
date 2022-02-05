using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFdz0506.Model;

namespace WPFdz0506.ViewModel
{
    class ViewModelNotes : INotifyPropertyChanged
    {
        DataContext context;
        NewNotes notes;
        private NewNotes selectedNotes;
        public NewNotes SelectedNotes
        {
            get { return selectedNotes; }
            set { selectedNotes = value; 
            
                OnPropertyChanged("SelectedNotes"); 
            }
        }
        
        public ObservableCollection<NewNotes> notesList { get; set; }

        public ViewModelNotes()
        {
            context = new DataContext("Server=(localdb)\\MSSQLLocalDB;Database=Notes;"); // <- на домашнем компе и только к локальной базе           
            notes = new NewNotes();
            notesList = new ObservableCollection<NewNotes>(context.GetTable<NewNotes>().ToList());

            NewNotes forUpdate = context.GetTable<NewNotes>().OrderByDescending(x => x.Id).FirstOrDefault();
            if (forUpdate != null)
            {
                forUpdate.CreatDateTime = forUpdate.CreatDateTime;
                forUpdate.isPerform = forUpdate.isPerform;
                forUpdate.CategoryId = forUpdate.CategoryId;
                forUpdate.description = forUpdate.description;
                context.SubmitChanges();
            }
        }

        private RelayCommand addCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(() =>
                    {
                        notesList.Add(new NewNotes(selectedNotes));
                        selectedNotes = new NewNotes();
                    }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

    }
}
