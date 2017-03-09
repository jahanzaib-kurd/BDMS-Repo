﻿using BDMS.Commands;
using BusinessModels;
using System.Collections.Generic;
using System.Windows.Input;
using BusinessLogicLayer;

namespace BDMS.ViewModels
{
    class AreaViewModel
    {
        private List<AreaModel> areas;
        private AreaModel updatedArea;
        //private CustomerInfoViewModel infoVM;
        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public AreaViewModel()
        {
            areas = BusinessModelParser.GetAreas();
            //infoVM = new CustomerInfoViewModel() { Info = "hello world" };
            UpdateCommand = new AreaUpdateCommand(this);
        }

        public List<AreaModel> Areas
        {
            get { return areas; }
        }

        public void SaveChanges()
        {
            //CustomerInfo view = new CustomerInfo();
            //view.DataContext = infoVM;
            //infoVM.Info = Customer.Name + " was updated";
            //view.ShowDialog();
        }
    }
}
