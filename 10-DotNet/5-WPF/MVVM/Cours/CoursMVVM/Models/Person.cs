using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursMVVM.Models
{
    class Person/* : INotifyPropertyChanged*/
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        private string firstname;
        private string lastname;
        private string gender;
        private bool isM;
        private bool isF;

        public string Firstname
        {
            get => firstname;
            set
            {
                firstname = value;
                //RaisePropertyChange("firstname");
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                lastname = value;
                //RaisePropertyChange("lastname");
            }
        }
        public bool IsM
        {
            get => isM;
            set
            {
                isM = value;
                //RaisePropertyChange("Gender");
            }
        }
        public bool IsF
        {
            get => isF;
            set
            {
                isF = value;
                //RaisePropertyChange("Gender");
            }
        }
        //public string Gender
        //{
        //    get
        //    {
        //        if (IsM)
        //            return "Homme";
        //        else if (IsF)
        //            return "Femme";
        //        else
        //            return null;
        //    } 

        //}

        //private void RaisePropertyChange(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
    }
}

