# Parcial #3

**Fecha:** [09/11/2026]

## Contenido del Repositorio

Diseño de jerarquía clases, abastracción, polimorfismo, uso de json y sistema de login desarrollado en C# con Windows Forms. El proyecto valida el acceso de usuarios contra una base de datos SQL Server, utilizando **hashing de contraseñas (BCrypt)** gestionado desde la capa de Negocio a través de dos contratos independientes (`IHashService` e `IVerificarHashService`).

## Tecnologías Utilizadas

- **Lenguaje / Framework:** C# — .NET Framework 4.7.2 (Windows Forms)
- **Base de datos:** SQL Server (SQL Server Express)
- **Librerías de UI:** MetroFramework (MetroModernUI), FontAwesome.Sharp
- **Serialización:** Newtonsoft.Json
- **Herramientas:** Visual Studio, SQL Server Management Studio (SSMS), Git

## Capturas de Pantalla y Problemas

### Problema 1 - Figuras 

Salida:\
<img width="1087" height="603" alt="image" src="https://github.com/user-attachments/assets/4b7a313b-8880-4233-91fa-20711312ec0c" />

### Problema 2 - JSON

Salida:\
<img width="1078" height="211" alt="image" src="https://github.com/user-attachments/assets/9ef0de2a-a02b-4041-9191-05e5402aeae7" />

### Problema 3 - Login con BCrypt

Salida:\
<img width="796" height="502" alt="image" src="https://github.com/user-attachments/assets/ee2cbe4d-05a3-4655-b952-5c535bf71039" />

## Estructura de Carpetas o Directorios
```
Solution/
├── Parcial 3 - Parte 1/      #Resolucion de la primera parte Figuras
├── Parcial 3 - Parte 2/      #Resolucion de la segunda parte JSON
├── Parcial 3 - Parte 3/      #Resolucion de la tercera parte login BCrypt
|   ├── Datos/                # Acceso a datos: conexión a SQL Server y consultas (D_Conexion, D_Usuario)
|   ├── Entidad/              # Clases de entidad (E_Usuarios) — modelos de datos puros 
|   ├── Negocio/               # Lógica de negocio y reglas de la aplicación
|   │   ├── Contratos/          # Interfaces: IHashService, IVerificarHashService
|   │   ├── Servicios/          # Implementaciones: BCrypt
|   │   └── N_Usuario.cs        # Orquesta la autenticación (obtiene usuario + verifica hash)
|   ├── Presentacion/          # Interfaz gráfica (Windows Forms): frmLogin, frmPrincipal
├── README.md               # Documentación del proyecto
└── db_login_bcrypt.sql    #Script sql de la base de datos utilizada
```

## Instrucciones de Ejecución / Uso

1. **Clonar el repositorio:**
   ```
   git clone https://github.com/Gabo943/Parcial-3---HPA-III
   ```
2. **Abrir la primera o segunda parte:**
   - Abrir el archivo `.slnx`
   - Ejecutarlo
4. **Abrir la tercera parte:**
   - Abrir `Solution.sln` en Visual Studio.
   - Restaurar los paquetes NuGet del proyecto (MetroModernUI, FontAwesome.Sharp, Newtonsoft.Json).
   - Ejecutar el script `db_sistema_login.sql` en SQL Server Management Studio para crear la base de datos, la tabla `t_usuario` y los stored procedures necesarios.
   - Verificar/ajustar la cadena de conexión en `Datos/D_Conexion.cs` según el nombre de tu instancia de SQL Server (`Server=localhost\SQLSERVEREXPRESS; Database=db_login_bcrypt; Trusted_Connection=True;`).
5. **Ejecutar el comando de arranque:**
   - Establecer el proyecto `Presentacion` como proyecto de inicio.
   - Ejecutar con `F5` desde Visual Studio.
   - Credenciales de prueba: usuario `admin`, contraseña `123456`.

## Autor y Contexto

- **Nombre:** Gabriel Jiménez
- **Institución:** Universidad Tecnológica de Panamá (UTP)
- **Fecha de Realización:** [09/11/2026]

## Referencias

- Documentos proporcionados por la profesora Irina Fong
