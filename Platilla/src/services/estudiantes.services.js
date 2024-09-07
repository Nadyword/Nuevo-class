export const handleKeyPress = async (studentId) => {

    
    try {
        const myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

        // Crear cuerpo de la petición con el ID del estudiante
        const raw = JSON.stringify({ id: studentId });

        const requestOptions = {
            method: "POST",
            headers: myHeaders,
            body: raw,
            redirect: "follow",
        };

        // Realizar la petición a la API de estudiantes
        const response = await fetch("http://localhost:5081/students", requestOptions);
        
        if (!response.ok) {
            throw new Error(`Error en la solicitud: ${response.statusText}`);
        }

        // Obtener el resultado en formato JSON
        const result = await response.json();
        console.log("Datos del estudiante:", result);
        return result;

    } catch (error) {
        console.error("Error al obtener los datos del estudiante:", error);
        throw error;
    }
};
