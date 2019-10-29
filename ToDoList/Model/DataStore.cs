using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoList.Model
{
    private ObservableCollection<Task> tasks;


    public class DataStore
    {
        public DataStore()
        {
            tasks = new ObservableCollection<Task>();
        }

        public void Add (string nombre)
        {
            Task.Add(new Task { Name = nombre });
        }
    }
}
