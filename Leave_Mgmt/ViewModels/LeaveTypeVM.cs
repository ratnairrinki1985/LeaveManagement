using System;
using System.ComponentModel.DataAnnotations;

namespace Leave_Mgmt.ViewModels
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Date Created")]
        public DateTime? DateCreated { get; set; }
    }
    //public class CreateLeaveTypeVM
    //{
    //    [Required]
    //    public string Name { get; set; }
    //}
}

