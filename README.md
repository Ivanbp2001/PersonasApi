# Personas API – Evaluación Técnica

API REST desarrollada en ASP.NET Core para la gestión de personas, como parte de una evaluación técnica.  
La aplicación implementa un CRUD completo utilizando Entity Framework Core y SQL Server.

---

## 🛠 Tecnologías utilizadas
- .NET 7
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Git

---

## Arquitectura del proyecto
El proyecto está organizado en capas para una mejor separación de responsabilidades:

- **Models**: Entidades del dominio.
- **Data**: Contexto de base de datos (DbContext).
- **Interfaces**: Contratos de servicios.
- **Services**: Lógica de negocio.
- **Controllers**: Endpoints de la API.

---

## Base de datos
La base de datos se crea mediante **Entity Framework Core Migrations**, lo que permite reproducir el entorno fácilmente sin depender de servicios externos.


---

## Video de explicación
Se incluye un video corto explicando la arquitectura del proyecto, el funcionamiento de la API y las pruebas realizadas en Swagger.

Video: https://youtu.be/XYQGb7V5iks

---



