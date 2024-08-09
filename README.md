# Muebles America Prototipo

Este proyecto es un prototipo de Muebles America, es un **clon/demo**.
  

## Propósito
El propósito de este prototipo:
- Proveer un ejemplo de cómo estructurar una aplicación con diferentes capas (Dominio, Aplicación, Infraestructura, Presentación).


## Estructura del Prototipo
- **Domain**: Contiene las entidades del dominio.
- **Application**: Contiene las interfaces y casos de uso.
- **Infrastructure**: Contiene las implementaciones de las interfaces de repositorio.
- **API**: Contiene los controladores de la API para interacturar con la aplicación.

```plaintext
MueblesNorteAmerica
├── MueblesNorteAmerica.Application
│   ├── Services
│   └── UseCases
├── MueblesNorteAmerica.Domain
│   ├── Models
│   └── Ports
├── MueblesNorteAmerica.Infrastructure
│   ├── Adapters
│   ├── Config
│   ├── Controllers
│   ├── Entities
│   └── Repositories
└── MueblesNorteAmerica.API
    └── Program.cs
```

## Tecnologías Utilizadas

- NET 8.0
- SQL Server