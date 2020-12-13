using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentValidation;

using FluentValidationDemo.Web.Models;

namespace FluentValidationDemo.Web.Validator
{
    public class UserLoginInfoModelValidator : AbstractValidator<UserLoginInfoModel>
    {
        public UserLoginInfoModelValidator()
        {
            RuleFor(x => x.UserName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("用户名不能为空");

            RuleFor(x => x.Pwd)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("密码不能为空");
        }
    }
}