using FluentValidation.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Web.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).
                EmailAddress().WithMessage("Email alanı doğru formatta olmalıdır.");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).
                InclusiveBetween(18, 60).WithMessage("Age alanı 18 ile 60 arasında olmalı");
            RuleFor(x => x.Brithday).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("Yaşnıız 18 yaşından büyük olmalı");
            RuleForEach(x => x.Adresses).SetValidator(new AddAdressValidator());
        }
    }
}
