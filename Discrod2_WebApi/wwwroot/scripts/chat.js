$(document).ready(function () {
    const usuarioId = sessionStorage.getItem("usuarioId");
    let usuarioDestinoId = null;

    if (!usuarioId) {
        alert("Debes iniciar sesión primero.");
        window.location.href = "../index.html";
        return;
    }

    // -----------------------------
    // Cargar lista de usuarios
    // -----------------------------
    function cargarUsuarios() {
        $.ajax({
            url: "/api/usuarios/listar",
            method: "GET",
            success: function (usuarios) {
                console.log("Usuarios cargados:", usuarios); // DEBUG
                $("#listaUsuarios").empty();

                usuarios.forEach(u => {
                    const imgSrc = u.imagen ? `data:image/png;base64,${u.imagen}` : "/img/default.png";
                    $("#listaUsuarios").append(`
                        <li data-id="${u.usuarioId}">
                            <img src="${imgSrc}" alt="avatar" />
                            <span>${u.nombre}</span>
                        </li>
                    `);
                });
            },
            error: function (xhr) {
                console.error("Error al cargar usuarios:", xhr.responseJSON || xhr.statusText);
                alert("Error al cargar usuarios.");
            }
        });
    }

    // -----------------------------
    // Seleccionar usuario destino
    // -----------------------------
    $("#listaUsuarios").on("click", "li", function () {
        usuarioDestinoId = $(this).data("id");
        cargarMensajes(usuarioDestinoId);
    });

    // -----------------------------
    // Cargar mensajes entre usuarios
    // -----------------------------
    function cargarMensajes(destinoId) {
        if (!destinoId) return;

        $.ajax({
            url: `/api/mensajes/entre-usuarios?origenId=${usuarioId}&destinoId=${destinoId}`,
            method: "GET",
            success: function (mensajes) {
                $("#mensajes").empty();

                mensajes.forEach(m => {
                    const clase = m.usuarioOrigen === parseInt(usuarioId) ? "mio" : "otro";
                    $("#mensajes").append(`<div class="burbuja ${clase}">${m.texto}</div>`);
                });

                $("#mensajes").scrollTop($("#mensajes")[0].scrollHeight);
            },
            error: function (xhr) {
                console.error("Error al cargar mensajes:", xhr.responseJSON || xhr.statusText);
            }
        });
    }

    // -----------------------------
    // Enviar mensaje
    // -----------------------------
    $("#btnEnviar").click(function () {
        const texto = $("#textoMensaje").val().trim();
        if (!texto || !usuarioDestinoId) return;

        $.ajax({
            url: "/api/mensajes/enviar",
            method: "POST",
            contentType: "application/json",
            data: JSON.stringify({
                texto: texto,
                usuarioOrigen: parseInt(usuarioId),
                usuarioDestino: usuarioDestinoId
            }),
            success: function () {
                $("#textoMensaje").val("");
                cargarMensajes(usuarioDestinoId);
            },
            error: function (xhr) {
                console.error("Error al enviar mensaje:", xhr.responseJSON || xhr.statusText);
            }
        });
    });

    // -----------------------------
    // Botones de navegación
    // -----------------------------
    $("#btnConfig").click(() => window.location.href = "configuracion.html");
    $("#btnCerrar").click(() => {
        sessionStorage.clear();
        window.location.href = "../index.html";
    });
    $("#btnAtras").click(() => window.location.href = "../index.html");

    // -----------------------------
    // Inicializar
    // -----------------------------
    cargarUsuarios();
});
