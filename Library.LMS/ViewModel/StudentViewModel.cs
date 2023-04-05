﻿using Library.LMS.Models;
using Library.LMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LMS.ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        public CourseService courseService { get; private set; }
        public PersonService personService { get; private set; }
        private Student student;

        public event PropertyChangedEventHandler? PropertyChanged;
        public StudentViewModel(Student student, CourseService Cservice, PersonService Pservice) 
        {
            this.student = student;
            PageTitle = "Signed in as: " + student.Name;
            courseService = Cservice;
            personService = Pservice;
        }


        string? _pageTitle;
        public string PageTitle
        {
            get { return _pageTitle ?? string.Empty; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged(nameof(PageTitle));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
