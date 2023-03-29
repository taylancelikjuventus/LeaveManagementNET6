
using AutoMapper;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Mapper
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            //Mapper Objesinin iki Yönlü Map(Obje Conversion ı) yapabilecegi tipler buraya aşagidaki gibi girilir. 
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestCreateVM>().ReverseMap();


            


        }

    }
}
