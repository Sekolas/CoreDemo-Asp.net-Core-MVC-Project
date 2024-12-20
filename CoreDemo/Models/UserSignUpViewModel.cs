﻿using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
	public class UserSignUpViewModel
	{
		[Display(Name ="Ad Soyad")]
		[Required(ErrorMessage ="Lütfen Ad Soyad Giriniz")]
		public string NameSurname { get; set; }

		[Display(Name = "Şifre")]
		[Required(ErrorMessage = "Lütfen Şifre Giriniz")]
		public string Password { get; set; }
		[Display(Name = "Şifre Tekrar")]
		[Compare("Password",ErrorMessage ="Şifreler uyuşmuyor!")]
		public string ConfrimPassword { get; set; }
		[Display(Name = "Mail")]
		[Required(ErrorMessage = "Lütfen Mail Giriniz")]
		public string Mail { get; set; }
		[Display(Name = "Username giriniz")]
		[Required(ErrorMessage = "Lütfen Username Giriniz")]
		public string UserName{ get; set; }	


	}
}
