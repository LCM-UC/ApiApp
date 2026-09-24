var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "API de Componentes de Computadora funcionando";
});

app.MapGet("/api/componentes", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            ID = 1,
            Nombre = "AMD Ryzen 7 7800X3D",
            Categoria = "Procesadores",
            Marca = "AMD",
            Precio = 449.99,
            Stock = 15,
            Descripcion = "Procesador de 8 núcleos y 16 hilos con tecnología 3D V-Cache"
        },
        new
        {
            ID = 2,
            Nombre = "Intel Core i7-14700K",
            Categoria = "Procesadores",
            Marca = "Intel",
            Precio = 409.99,
            Stock = 12,
            Descripcion = "Procesador de 20 núcleos (8P + 12E) y 28 hilos hasta 5.6 GHz"
        },
        new
        {
            ID = 3,
            Nombre = "NVIDIA GeForce RTX 4070 Super",
            Categoria = "Tarjetas de Video",
            Marca = "NVIDIA",
            Precio = 599.99,
            Stock = 8,
            Descripcion = "Tarjeta gráfica de 12GB GDDR6X con arquitectura Ada Lovelace y DLSS 3"
        },
        new
        {
            ID = 4,
            Nombre = "AMD Radeon RX 7800 XT",
            Categoria = "Tarjetas de Video",
            Marca = "AMD",
            Precio = 499.99,
            Stock = 10,
            Descripcion = "Tarjeta gráfica con 16GB GDDR6 y arquitectura RDNA 3 para gaming 1440p"
        },
        new
        {
            ID = 5,
            Nombre = "Corsair Vengeance DDR5 32GB (2x16GB)",
            Categoria = "Memorias RAM",
            Marca = "Corsair",
            Precio = 114.99,
            Stock = 25,
            Descripcion = "Kit de memoria RAM DDR5 6000MHz CL30 con perfiles AMD EXPO e Intel XMP"
        },
        new
        {
            ID = 6,
            Nombre = "Kingston Fury Beast DDR4 16GB (2x8GB)",
            Categoria = "Memorias RAM",
            Marca = "Kingston",
            Precio = 45.50,
            Stock = 30,
            Descripcion = "Memoria RAM DDR4 3200MHz CL16 con disipador de perfil bajo"
        },
        new
        {
            ID = 7,
            Nombre = "Samsung 990 PRO 2TB NVMe M.2",
            Categoria = "Almacenamiento",
            Marca = "Samsung",
            Precio = 179.99,
            Stock = 20,
            Descripcion = "SSD PCIe 4.0 con velocidades de lectura de hasta 7450 MB/s y escritura de 6900 MB/s"
        },
        new
        {
            ID = 8,
            Nombre = "Kingston NV2 1TB NVMe M.2",
            Categoria = "Almacenamiento",
            Marca = "Kingston",
            Precio = 62.00,
            Stock = 35,
            Descripcion = "SSD PCIe 4.0 NVMe ideal para almacenamiento rápido en portátiles y PC de escritorio"
        },
        new
        {
            ID = 9,
            Nombre = "ASUS TUF Gaming B650-PLUS WiFi",
            Categoria = "Placas Madre",
            Marca = "ASUS",
            Precio = 219.99,
            Stock = 14,
            Descripcion = "Tarjeta madre ATX para socket AM5 con soporte DDR5, PCIe 5.0 y Wi-Fi 6"
        },
        new
        {
            ID = 10,
            Nombre = "Corsair RM750e 750W 80 Plus Gold",
            Categoria = "Fuentes de Poder",
            Marca = "Corsair",
            Precio = 99.99,
            Stock = 16,
            Descripcion = "Fuente de poder totalmente modular, estándar ATX 3.0 y PCIe 5.0"
        }
    });
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");

