using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLineApi.Infrastructure.Models;
using FluentValidation;

namespace CommandLineApi.Infrastructure.ModelValidationUtility
{
    public class CommandItemValidator : AbstractValidator<Command>
    {
        public CommandItemValidator()
        {
            RuleFor(c => c.CommandName).NotEmpty()
                .NotNull()
                .Length(2, 30);
            RuleFor(cs => cs.CommandSnippet).NotEmpty()
                .NotNull()
                .Length(2, 100);
            RuleFor(os => os.OS).NotEmpty()
                .NotNull()
                .Length(2, 20);
            RuleFor(t => t.TargetEnvironment).NotEmpty()
                .NotNull()
                .Length(2, 30);
        }
    }
}
