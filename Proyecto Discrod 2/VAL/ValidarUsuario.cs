using FluentValidation;


namespace Proyecto_Discrod_2.VAL
{
    public class ValidarUsuario: AbstractValidator<BE.Usuarios>
    {
        public ValidarUsuario() 
        {
            RuleFor(u => u.Nombre)
                .NotEmpty().WithMessage("El nombre no puede estar vacío.")
                .Length(3, 50).WithMessage("El nombre debe tener entre 3 y 50 caracteres.");
            RuleFor(u => u.Password)
                .Matches(@"[A-Z]").WithMessage("La contraseña debe contener al menos una mayúscula.")
                .Matches(@"[a-z]").WithMessage("La contraseña debe contener al menos una minúscula.")
                .Matches(@"\d").WithMessage("La contraseña debe contener al menos un número.")
                .MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres.");
            RuleFor(u => u.Color)
                .NotEqual(0).WithMessage("Debe seleccionar un color.");
            RuleFor(u => u.Imagen)
                .NotNull().WithMessage("La imagen no puede ser nula.");
        }
    }

}
