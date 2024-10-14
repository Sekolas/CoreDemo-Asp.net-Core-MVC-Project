using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
	public class WriterValidatör:AbstractValidator<Writer>
	{
        public WriterValidatör()
        {

			RuleFor(x => x.WriterName)
		   .NotEmpty().WithMessage("Yazar adı soyadı boş olamaz");

			RuleFor(x => x.WriterMail)
				.NotEmpty().WithMessage("Mail adresi boş olamaz")
				.EmailAddress().WithMessage("Geçerli bir e-posta adresi girin");

			RuleFor(x => x.WriterPassword)
				.NotEmpty().WithMessage("Şifre boş olamaz")
				.MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır")
				.Matches(@"[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir")
				.Matches(@"[a-z]").WithMessage("Şifre en az bir küçük harf içermelidir")
				.Matches(@"[0-9]").WithMessage("Şifre en az bir rakam içermelidir");




		}

	}
}
