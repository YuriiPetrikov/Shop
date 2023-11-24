using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длина имени более 25 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии более 25 символов")]
        public string surname { get; set; }

        [Display(Name = "Адресс")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса более 35 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина номера более 20 знаков")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина Email более 15 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        [ValidateNever]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
