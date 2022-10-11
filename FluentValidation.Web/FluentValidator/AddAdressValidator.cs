using FluentValidation.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Web.FluentValidator
{
    public class AddAdressValidator : AbstractValidator<Adress>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";
        public AddAdressValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Province).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.PostCode).NotEmpty().WithMessage(NotEmptyMessage).
                MaximumLength(5).WithMessage("{PropertyName} en fazla {MaxLength} karakterden oluşmalı");

        }
    }
}
