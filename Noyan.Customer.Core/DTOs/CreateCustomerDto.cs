using Noyan.Customers.Core.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Core.DTOs
{
    public class CreateCustomerDto 
    {
        /// <summary>
        /// شماره مشتری
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// نام 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی 
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// نام پدر
        /// </summary>
        public string FatherName { get; set; }

        /// <summary>
        /// شماره شناسنامه
        /// </summary>
        public string BirthCertificate { get; set; }

        /// <summary>
        /// کدملی
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// تاریخ تولد 
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// موبایل
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// آدرس 
        /// </summary>
        public string Address { get; set; }
    }
}
