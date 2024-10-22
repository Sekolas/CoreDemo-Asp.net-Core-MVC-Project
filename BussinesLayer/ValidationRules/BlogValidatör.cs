using EntityLayer.concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class BlogValidatör:AbstractValidator<Blog>
    {
        public BlogValidatör()
        {
            RuleFor(x => x.BlogTitle)
           .NotEmpty().WithMessage("Blog adı boş olamaz");
            RuleFor(x => x.BlogContent)
           .NotEmpty().WithMessage("Blog içeriği boş olamaz");
            RuleFor(x => x.BlogTitle)
           .MaximumLength(150).WithMessage("lütfen 150 karakteri aşmayınız");
            RuleFor(x => x.BlogTitle)
           .MinimumLength(5).WithMessage("lütfen 5 karakterden fazla girin");

        }

    }
}
