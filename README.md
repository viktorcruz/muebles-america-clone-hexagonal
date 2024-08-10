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
MueblesAmerica
├── MueblesAmerica.Application
│   └── UseCases
├── MueblesAmerica.Domain
│   ├── Models
│   └── Ports
│       ├── In
│       └── Out
├── MueblesAmerica.Infrastructure
│   ├── Adapters
│   ├── Entities
│   └── Factories
└── MueblesAmerica.API
    ├── Controllers
    └── Modules
```

## Tecnologías Utilizadas

- NET 8.0
- SQL Server