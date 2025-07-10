using FluentValidation;
using Proyecto_Discrod_2.BE;


namespace Proyecto_Discrod_2.VAL
{
    public class ValidarUsuario : AbstractValidator<Usuarios>
    {
        public ValidarUsuario()
        {
            RuleFor(u => u.Nombre)
                .NotEmpty().WithMessage("El nombre no puede estar vacío.")
                .Length(3, 50).WithMessage("El nombre debe tener entre 3 y 50 caracteres.")
                .Matches("^[a-zA-Z0-9_\\- ]*$").WithMessage("El nombre contiene caracteres inválidos.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("La contraseña no puede estar vacía.")
                .Matches(@"[A-Z]").WithMessage("La contraseña debe contener al menos una mayúscula.")
                .Matches(@"[a-z]").WithMessage("La contraseña debe contener al menos una minúscula.")
                .Matches(@"\d").WithMessage("La contraseña debe contener al menos un número.")
                .MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres.")
                .Must(pw => !ContieneSQL(pw)).WithMessage("La contraseña contiene patrones no permitidos.");

            RuleFor(u => u.Color)
                .NotEqual(0).WithMessage("Debe seleccionar un color.");

            RuleFor(u => u.Imagen)
                .NotNull().WithMessage("La imagen no puede ser nula.");
        }

        private bool ContieneSQL(string input)
        {
            // Reglas básicas para detectar inyecciones clásicas
            string[] palabrasProhibidas = new[]
            {
            "SELECT", "INSERT", "UPDATE", "DELETE", "DROP", "--", ";", "'", "\"", "/*", "*/"
        };

            return palabrasProhibidas.Any(p => input.ToUpper().Contains(p));
        }
    }


}
