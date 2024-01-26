using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategory adını boş keçəməzsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategory adını boş keçəməzsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az  3  karakter  girisi yapı");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En çok  20  karakter  girisi yapı");
        }
    }
}
