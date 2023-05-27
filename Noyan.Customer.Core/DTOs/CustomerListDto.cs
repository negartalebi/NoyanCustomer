using Noyan.Customers.Core.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Core.DTOs
{
  public  class CustomerListDto:BaseDTO
    {
        /// <summary>
        /// شماره مشتری
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// نام 
        /// </summary>
        public string NameFamily { get; set; }

         

        /// <summary>
        /// کدملی
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// تاریخ تولد شمسی 
        /// </summary>
        public string BirthdateFa { get; set; }

    }
}
