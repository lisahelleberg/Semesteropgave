﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using JanitorSystem.Facade;
using JanitorSystem.Model;
using JanitorSystem.ViewModel;
using Windows.UI.Popups;

namespace JanitorSystem.Handlers
{
    public class AssignmentHandler
    {
        #region Properties

        public AddAssignmentViewModel Avm { get; set; }

        #endregion

        #region Comstructor that includes the local parameter avm of type AddAssignmentViewModel.

        public AssignmentHandler(AddAssignmentViewModel avm)
        {
            Avm = avm;
        }
        #endregion

        #region AddAssignment Method

        /// <summary>
        /// The addAssignment method includes and if else to allow help boxes for the user in the view.
        /// The message dialogboxes are wrapped in pragma. 
        /// </summary>
        public void AddAssignment()
        {
            
            if (Avm.Assignment.AssignTitle != null && Avm.Assignment.AssignText != null &&
                Avm.Assignment.AssignRankNo > 0 && Avm.SelectedAppartmentId.AppartNo > 0 &&
                Avm.SelectedDepartmentId.DepId > 0 && Avm.SelectedEmployeeId.EmployeeId > 0)
            {
               
                Assignment tempAssignment = new Assignment();

                tempAssignment.AssignTitle = Avm.Assignment.AssignTitle;
                tempAssignment.AssignText = Avm.Assignment.AssignText;
                tempAssignment.AssignRankNo = Avm.Assignment.AssignRankNo;
                tempAssignment.AppartNo = Avm.SelectedAppartmentId.AppartNo;
                tempAssignment.AssignComment = "Kommentar: ";
                tempAssignment.DepId = Avm.SelectedDepartmentId.DepId;
                tempAssignment.EmployeeId = Avm.SelectedEmployeeId.EmployeeId;
                Avm.Singleton.AddAssignment(tempAssignment);
                Avm.Singleton.ClearAssignmentList();
                Avm.Singleton.LoadAssignmentList();

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                new MessageDialog("Du har oprettet opgave").ShowAsync();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            }
            else
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                new MessageDialog("Har du glemt at udfylde et felt?").ShowAsync();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

            }
        }

        public void SetPriorityToOne()
        {
            Avm.Assignment.AssignRankNo = 1;
        }

        public void SetPriorityToTwo()
        {
            Avm.Assignment.AssignRankNo = 2;
        }

        public void SetPriorityToThree()
        {
            Avm.Assignment.AssignRankNo = 3;
        }

        #endregion

        #region Delete assignment method
        public void DeleteAssignment()
        {
            Avm.Singleton.RemoveAssignment(ViceListsSingleton.Instance.SelectedAssignmentMVM);
        }

        #endregion
    }
}
