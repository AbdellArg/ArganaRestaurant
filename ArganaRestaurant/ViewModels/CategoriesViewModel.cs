using ArganaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.ViewModels
{
    internal class CategoriesViewModel
    {
        private int id;
        private string name;
        private Uri icon;

        public CategoriesViewModel()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Uri Icon
        {
            get { return icon; }
            set { icon = value; }
        }


        

    }
}
