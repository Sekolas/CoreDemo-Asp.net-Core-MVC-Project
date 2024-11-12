using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() {
            RuleFor(x => x.CategoryName)
           .NotEmpty().WithMessage("Kategori adı boş olamaz");
            RuleFor(x => x.CategoryDescription)
           .NotEmpty().WithMessage("içerik boş olamaz");
            RuleFor(x => x.CategoryName)
           .MaximumLength(50).WithMessage("başlık 150 karakteri aşmayınız");
        }

    }
}
