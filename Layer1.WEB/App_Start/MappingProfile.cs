using AutoMapper;
using Layer1.ENTITIES;
using Layer1.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Layer1.WEB.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CStudent, CStudentViewModel>();
            CreateMap<CStudentViewModel,CStudent>();
        }
    }
}