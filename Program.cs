var builder = WebApplication.CreateBuilder(args);

// Configuración crucial para Render: Leer la variable de entorno PORT dinámica
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "API NovaTech Hardware funcionando. Endpoints disponibles: /api/productos, /api/categorias, /api/clientes, /api/pedidos";
});

// Recurso 1: Productos 
app.MapGet("/api/productos", () =>
{
    return Results.Ok(new[]
    {
        // ---------------- CATEGORÍA 1: Laptops y Computadoras (CategoriaId = 1) ----------------
        new { 
            Id = 1, Nombre = "Laptop Gamer ASUS ROG Strix", Precio = 1500.00, 
            Especificaciones = "Intel Core i7, 16GB RAM, RTX 4060, 1TB SSD", 
            CategoriaId = 1, Stock = 10, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=ASUS+ROG+Strix" 
        },
        new { 
            Id = 2, Nombre = "Laptop Lenovo Legion Pro 5", Precio = 1650.00, 
            Especificaciones = "AMD Ryzen 7, 32GB RAM, RTX 4070, 1TB SSD", 
            CategoriaId = 1, Stock = 8, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Lenovo+Legion" 
        },
        new { 
            Id = 3, Nombre = "Apple MacBook Pro 16\"", Precio = 2499.00, 
            Especificaciones = "Chip M3 Pro, 18GB RAM, 512GB SSD", 
            CategoriaId = 1, Stock = 5, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=MacBook+Pro+16" 
        },
        new { 
            Id = 4, Nombre = "PC Armada Gamer", Precio = 1200.00, 
            Especificaciones = "Intel Core i5, 16GB RAM, RTX 4060 Ti, 1TB NVMe", 
            CategoriaId = 1, Stock = 12, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=PC+Armada" 
        },
        new { 
            Id = 5, Nombre = "Laptop HP Victus 15", Precio = 899.00, 
            Especificaciones = "Intel Core i5, 8GB RAM, RTX 3050, 512GB SSD", 
            CategoriaId = 1, Stock = 20, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=HP+Victus" 
        },

        // ---------------- CATEGORÍA 2: Periféricos (CategoriaId = 2) ----------------
        new { 
            Id = 6, Nombre = "Teclado Mecánico Razer Tenkeyless", Precio = 130.00, 
            Especificaciones = "Formato TKL, Switches mecánicos, Iluminación RGB", 
            CategoriaId = 2, Stock = 25, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Teclado+Razer+TKL" 
        },
        new { 
            Id = 7, Nombre = "Audífonos Inalámbricos Razer", Precio = 150.00, 
            Especificaciones = "Sonido envolvente 7.1, Inalámbrico, Micrófono retráctil", 
            CategoriaId = 2, Stock = 18, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Audifonos+Razer+7.1" 
        },
        new { 
            Id = 8, Nombre = "Mouse Logitech G Pro X Superlight", Precio = 140.00, 
            Especificaciones = "Sensor HERO 25K, 63 gramos, Inalámbrico", 
            CategoriaId = 2, Stock = 30, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Mouse+Logitech+GPro" 
        },
        new { 
            Id = 9, Nombre = "Monitor LG UltraGear 27\"", Precio = 300.00, 
            Especificaciones = "144Hz, Panel IPS, 1ms, Resolución 1440p", 
            CategoriaId = 2, Stock = 15, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Monitor+LG+27" 
        },
        new { 
            Id = 10, Nombre = "Micrófono Elgato Wave:3", Precio = 160.00, 
            Especificaciones = "Condensador USB, Software Wave Link", 
            CategoriaId = 2, Stock = 22, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Microfono+Elgato" 
        },

        // ---------------- CATEGORÍA 3: Componentes y Almacenamiento (CategoriaId = 3) ----------------
        new { 
            Id = 11, Nombre = "SSD NVMe M.2 Samsung 980 PRO 1TB", Precio = 85.00, 
            Especificaciones = "Interfaz PCIe Gen 4, Lectura hasta 7000MB/s", 
            CategoriaId = 3, Stock = 40, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=SSD+Samsung+M2" 
        },
        new { 
            Id = 12, Nombre = "Procesador AMD Ryzen 7 7800X3D", Precio = 399.00, 
            Especificaciones = "8 Núcleos, 16 Hilos, Arquitectura Zen 4, 3D V-Cache", 
            CategoriaId = 3, Stock = 15, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Ryzen+7" 
        },
        new { 
            Id = 13, Nombre = "Tarjeta de Video NVIDIA RTX 4070 Ti", Precio = 799.00, 
            Especificaciones = "12GB GDDR6X, DLSS 3, Ray Tracing", 
            CategoriaId = 3, Stock = 10, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=RTX+4070+Ti" 
        },
        new { 
            Id = 14, Nombre = "Memoria RAM Corsair Vengeance 32GB", Precio = 110.00, 
            Especificaciones = "2x16GB, DDR5, 6000MHz, RGB", 
            CategoriaId = 3, Stock = 35, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=RAM+Corsair+32GB" 
        },
        new { 
            Id = 15, Nombre = "Fuente de Poder EVGA SuperNOVA 850W", Precio = 125.00, 
            Especificaciones = "80 Plus Gold, Totalmente Modular", 
            CategoriaId = 3, Stock = 20, 
            Imagen = "https://placehold.co/400x400/2a2a2a/ffffff?text=Fuente+EVGA+850W" 
        }
    });
});

// Recurso 2: Categorías 
app.MapGet("/api/categorias", () =>
{
    return Results.Ok(new[]
    {
        new { Id = 1, Nombre = "Laptops y Computadoras", Descripcion = "Equipos armados y portátiles para gaming y trabajo" },
        new { Id = 2, Nombre = "Periféricos", Descripcion = "Teclados, mouses, monitores y audífonos de alto rendimiento" },
        new { Id = 3, Nombre = "Componentes y Almacenamiento", Descripcion = "Tarjetas de video, procesadores, SSDs y memoria RAM" }
    });
});

// Recurso 3: Clientes 
app.MapGet("/api/clientes", () =>
{
    return Results.Ok(new[]
    {
        new { Id = 1, Nombre = "Leonardo", Email = "leonardo@ejemplo.com", Tipo = "Gamer Entusiasta", FechaRegistro = "2026-05-10" },
        new { Id = 2, Nombre = "Ana", Email = "ana@ejemplo.com", Tipo = "Profesional TI", FechaRegistro = "2026-08-22" }
    });
});

// Recurso 4: Pedidos 
app.MapGet("/api/pedidos", () =>
{
    return Results.Ok(new[]
    {
        new { Id = 101, ClienteId = 1, Fecha = DateTime.UtcNow.AddDays(-2), Total = 120.00, Estado = "Completado" },
        new { Id = 102, ClienteId = 2, Fecha = DateTime.UtcNow.AddHours(-5), Total = 1585.00, Estado = "Pendiente" }
    });
});

app.Run();