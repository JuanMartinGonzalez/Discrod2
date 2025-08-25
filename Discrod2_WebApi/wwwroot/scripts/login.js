$(document).ready(function () {
    $('#loginForm').on('submit', function (e) {
        e.preventDefault();

        const nombre = $('#usuario').val();
        const password = $('#contrasena').val();

        if (!nombre || !password) {
            alert("Por favor completá usuario y contraseña.");
            return;
        }

        const formData = new FormData();
        formData.append("Nombre", nombre);
        formData.append("Password", password);

        $.ajax({
            url: "/api/usuarios/login",
            method: "POST",
            data: formData,
            processData: false,
            contentType: false,
            success: function (response) {
                alert("Login exitoso. Bienvenido " + response.nombre);

                // Acá podés guardar datos del usuario en sessionStorage/localStorage
                // por ejemplo:
                sessionStorage.setItem("usuarioId", response.usuarioId);
                sessionStorage.setItem("nombre", response.nombre);
                sessionStorage.setItem("color", response.color);

                // Redirigimos al chat o a donde quieras
                window.location.href = "views/home.html";
            },
            error: function (xhr) {
                if (xhr.status === 401) {
                    alert("Contraseña incorrecta.");
                } else if (xhr.status === 404) {
                    alert("El usuario no existe.");
                } else {
                    alert("Error en login: " + (xhr.responseJSON?.mensaje || xhr.statusText));
                }
            }
        });
    });
});
