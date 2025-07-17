$(document).ready(function ()
{
    $('#registrationForm').on('submit', function (e) {
        e.preventDefault();

        const form = document.getElementById('registrationForm');
        const formData = new FormData();

        // Obtener los campos del formulario
        const nombre = $('#nombre').val();
        const contrasena = $('#contrasenaRegistro').val();
        const color = $('#colorFavorito').val();
        const imagen = $('#archivoImagen')[0].files[0];

        // Validar usuario (opcional)
        if (!nombre || !contrasena) {
            alert("Por favor completá nombre y contraseña.");
            return;
        }

        // Agregar datos al FormData
        formData.append("Nombre", nombre);
        formData.append("Password", contrasena);
        formData.append("Color", parseInt(color.replace('#', '0x'))); // Convertir a int estilo ARGB
        if (imagen) {
            formData.append("Imagen", imagen);
        }

        // Enviar AJAX
        $.ajax({
            url: "/api/usuarios/registrar",
            method: "POST",
            data: formData,
            processData: false,
            contentType: false,
            success: function (response) {
                alert("Registro exitoso. ID: " + response.usuarioId);
                window.location.href = "../index.html"; // O donde quieras redirigir
            },
            error: function (xhr) {
                if (xhr.status === 400 && xhr.responseJSON?.errores) {
                    alert("Errores:\n" + xhr.responseJSON.errores.join('\n'));
                } else {
                    alert("Error en el registro:\n" + xhr.statusText);
                }
            }
        });
    });
});
