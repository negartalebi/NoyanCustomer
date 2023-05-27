 
namespace Noyan.Customers.Core.Domain
{
    public class Customer:BaseEntity
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
        public string  FatherName { get; set; }

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
