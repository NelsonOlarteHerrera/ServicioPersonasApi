document.addEventListener("DOMContentLoaded", async () => {
    const contenedor = document.getElementById("personas-container");

    try {
        const respuesta = await fetch("https://localhost:5087/api/personas");
        const personas = await respuesta.json();

        personas.forEach(p => {
            const div = document.createElement("div");
            div.classList.add("persona");
            div.innerHTML = `
        <img src="${p.fotografia}" alt="Foto de ${p.nombreCompleto}" />
        <h2>${p.nombreCompleto}</h2>
        <p><strong>Género:</strong> ${p.genero}</p>
        <p><strong>Ubicación:</strong> ${p.ubicacion}</p>
        <p><strong>Email:</strong> ${p.correoElectronico}</p>
        <p><strong>Fecha de nacimiento:</strong> ${new Date(p.fechaNacimiento).toLocaleDateString()}</p>
      `;
            contenedor.appendChild(div);
        });
    } catch (error) {
        contenedor.innerHTML = `<p style="color:red;">Error al cargar los datos.</p>`;
        console.error("Error:", error);
    }
});
