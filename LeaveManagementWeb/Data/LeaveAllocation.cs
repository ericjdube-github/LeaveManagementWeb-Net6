using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        //  Foreign Key....
        [ForeignKey("LeaveTypeId")]  
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }


        public int EmployeeId { get; set; }
    }
}
