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

// Lista de componentes con imágenes integradas en la API
var componentes = new List<ComponenteDto>
{
    new ComponenteDto
    {
        ID = 1,
        Nombre = "AMD Ryzen 7 7800X3D",
        Categoria = "Procesadores",
        Marca = "AMD",
        Precio = 449.99,
        Stock = 15,
        Descripcion = "Procesador de 8 núcleos y 16 hilos con tecnología 3D V-Cache",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAW7xCPjo4FVGshTZgMVI6XT7VpplzFRPEvomG9fkNaA2hr8rncx12NReZMfN9pckPqAQhYxhOVQJ6WBgm3mHbJcbBRnDZ-Xc7peknR1ozA_FqA-g5czVt1rcEv5_3nabSkzqhUSQ4I8-nSIDySWlOoV5sg2ijWOQvlh5I4kQGymECTttUDSW4VqH0RuQ8WoVJm6UYfW57FdNEuw7M2UEhUa8De8ESqit2XZrLqAIcawCHWoI_2zAbFwA"
    },
    new ComponenteDto
    {
        ID = 2,
        Nombre = "Intel Core i7-14700K",
        Categoria = "Procesadores",
        Marca = "Intel",
        Precio = 409.99,
        Stock = 12,
        Descripcion = "Procesador de 20 núcleos (8P + 12E) y 28 hilos hasta 5.6 GHz",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAW7xCPjo4FVGshTZgMVI6XT7VpplzFRPEvomG9fkNaA2hr8rncx12NReZMfN9pckPqAQhYxhOVQJ6WBgm3mHbJcbBRnDZ-Xc7peknR1ozA_FqA-g5czVt1rcEv5_3nabSkzqhUSQ4I8-nSIDySWlOoV5sg2ijWOQvlh5I4kQGymECTttUDSW4VqH0RuQ8WoVJm6UYfW57FdNEuw7M2UEhUa8De8ESqit2XZrLqAIcawCHWoI_2zAbFwA"
    },
    new ComponenteDto
    {
        ID = 3,
        Nombre = "NVIDIA GeForce RTX 4070 Super",
        Categoria = "Tarjetas de Video",
        Marca = "NVIDIA",
        Precio = 599.99,
        Stock = 8,
        Descripcion = "Tarjeta gráfica de 12GB GDDR6X con arquitectura Ada Lovelace y DLSS 3",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuC1844ShpZyZeeJV9ABTvNTm0nG9iPvj-8MYNZhLIYTcKI94x_u94iMLEkxjzQdl8dCLozBaBZnDpqWiCa3yr6q3Q9JmlVe_bnaYnqdnMCcSZ2ZgF6Sqz1DkIt2BmXv5ekCxaXDloyNRPe487sLG5Vf4SZDGrn7bJU8VtJymASrigbNw6j4AG2dsqTzFqw2UDyvyxR55y_KDZGXFWkmx06ABfxkKcfBn926h2mb_5Iu-LPtPxO-k1N0Jg"
    },
    new ComponenteDto
    {
        ID = 4,
        Nombre = "AMD Radeon RX 7800 XT",
        Categoria = "Tarjetas de Video",
        Marca = "AMD",
        Precio = 499.99,
        Stock = 10,
        Descripcion = "Tarjeta gráfica con 16GB GDDR6 y arquitectura RDNA 3 para gaming 1440p",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAMfzipTGwY8zNGGjm87vx-rW4AsXZNrK2LFLK_zHTOP7yfBoouEFz6ZJ4HBjhF3xJLC1MwPewRNy_zD5f15cmlw0sgZLaCXeNQCjDYXHbb8lscIcCtxuEnJrxSP5PzsV_o-OexaWbfWmVJBkcWxGrmWbMTykadqyzw4QZb7Ute_BihsJ2Ux-nwTItJPu1SDXKgAG3-sUM_SUMfL14jJH3qKaIcQpLK4-YIibsFpzIkOAl76LAI1HMpow"
    },
    new ComponenteDto
    {
        ID = 5,
        Nombre = "Corsair Vengeance DDR5 32GB (2x16GB)",
        Categoria = "Memorias RAM",
        Marca = "Corsair",
        Precio = 114.99,
        Stock = 25,
        Descripcion = "Kit de memoria RAM DDR5 6000MHz CL30 con perfiles AMD EXPO e Intel XMP",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAliGMJinp3P3neQ--a-QONZGPp3Ck0fbyRkKUTnE9AKopUyo39HBTNx2zhTM9vuhyla4rFixA5pwzM4A_3scQ93xxlyeCsY0Vgir0xzGm45OfI-DtZOc6cLu46tCngaykTQwMox2mrODRNkjVTbtt5CzjuTjoljkq2eUNVy1jMhZasbybLmzz0UKmBHCdmjqC3yEYgSrz8KSdWP_i7-uFHo_53H1LeL2Nm81QzuLXJsf4jbjYi-ojl0g"
    },
    new ComponenteDto
    {
        ID = 6,
        Nombre = "Kingston Fury Beast DDR4 16GB (2x8GB)",
        Categoria = "Memorias RAM",
        Marca = "Kingston",
        Precio = 45.50,
        Stock = 30,
        Descripcion = "Memoria RAM DDR4 3200MHz CL16 con disipador de perfil bajo",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAliGMJinp3P3neQ--a-QONZGPp3Ck0fbyRkKUTnE9AKopUyo39HBTNx2zhTM9vuhyla4rFixA5pwzM4A_3scQ93xxlyeCsY0Vgir0xzGm45OfI-DtZOc6cLu46tCngaykTQwMox2mrODRNkjVTbtt5CzjuTjoljkq2eUNVy1jMhZasbybLmzz0UKmBHCdmjqC3yEYgSrz8KSdWP_i7-uFHo_53H1LeL2Nm81QzuLXJsf4jbjYi-ojl0g"
    },
    new ComponenteDto
    {
        ID = 7,
        Nombre = "Samsung 990 PRO 2TB NVMe M.2",
        Categoria = "Almacenamiento",
        Marca = "Samsung",
        Precio = 179.99,
        Stock = 20,
        Descripcion = "SSD PCIe 4.0 con velocidades de lectura de hasta 7450 MB/s y escritura de 6900 MB/s",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAMkOjWilsINxkkIbA4yp4HozrevtMMectUf3Y-qlrcWAnCRdE1w41ls326S2H0NYNPAldxn-lWlIm7WYxCaL7Kc6esDOl3F6ijxpzgQT4hcBmzSYxdOQhiZEv6_Hrcidb9RB6zVu8Rne2WEIrczFFS2SK-rR7_3m_jyypid6WgRTiQ-aS_RXJ14ogAAmcq6-zZC_ynbGbOXsUlx8KC3tEMFC_eR2KjIRhekTTbJ8Glt0Z9_PQ_Plyw8Q"
    },
    new ComponenteDto
    {
        ID = 8,
        Nombre = "Kingston NV2 1TB NVMe M.2",
        Categoria = "Almacenamiento",
        Marca = "Kingston",
        Precio = 62.00,
        Stock = 35,
        Descripcion = "SSD PCIe 4.0 NVMe ideal para almacenamiento rápido en portátiles y PC de escritorio",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuAMkOjWilsINxkkIbA4yp4HozrevtMMectUf3Y-qlrcWAnCRdE1w41ls326S2H0NYNPAldxn-lWlIm7WYxCaL7Kc6esDOl3F6ijxpzgQT4hcBmzSYxdOQhiZEv6_Hrcidb9RB6zVu8Rne2WEIrczFFS2SK-rR7_3m_jyypid6WgRTiQ-aS_RXJ14ogAAmcq6-zZC_ynbGbOXsUlx8KC3tEMFC_eR2KjIRhekTTbJ8Glt0Z9_PQ_Plyw8Q"
    },
    new ComponenteDto
    {
        ID = 9,
        Nombre = "ASUS TUF Gaming B650-PLUS WiFi",
        Categoria = "Placas Madre",
        Marca = "ASUS",
        Precio = 219.99,
        Stock = 14,
        Descripcion = "Tarjeta madre ATX para socket AM5 con soporte DDR5, PCIe 5.0 y Wi-Fi 6",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuBPX3qYm8E5QvX6e2gqLg-X8yJqjO2G-cI"
    },
    new ComponenteDto
    {
        ID = 10,
        Nombre = "Corsair RM750e 750W 80 Plus Gold",
        Categoria = "Fuentes de Poder",
        Marca = "Corsair",
        Precio = 99.99,
        Stock = 16,
        Descripcion = "Fuente de poder totalmente modular, estándar ATX 3.0 y PCIe 5.0",
        Imagen = "https://lh3.googleusercontent.com/aida-public/AB6AXuC1844ShpZyZeeJV9ABTvNTm0nG9iPvj-8MYNZhLIYTcKI94x_u94iMLEkxjzQdl8dCLozBaBZnDpqWiCa3yr6q3Q9JmlVe_bnaYnqdnMCcSZ2ZgF6Sqz1DkIt2BmXv5ekCxaXDloyNRPe487sLG5Vf4SZDGrn7bJU8VtJymASrigbNw6j4AG2dsqTzFqw2UDyvyxR55y_KDZGXFWkmx06ABfxkKcfBn926h2mb_5Iu-LPtPxO-k1N0Jg"
    }
};

app.MapGet("/api/componentes", () =>
{
    return Results.Ok(componentes);
});

app.MapGet("/api/componentes/{id:int}", (int id) =>
{
    var item = componentes.FirstOrDefault(c => c.ID == id);
    return item is not null ? Results.Ok(item) : Results.NotFound();
});

app.MapPost("/api/componentes", (ComponenteDto nuevo) =>
{
    nuevo.ID = componentes.Any() ? componentes.Max(c => c.ID) + 1 : 1;
    componentes.Add(nuevo);
    return Results.Created($"/api/componentes/{nuevo.ID}", nuevo);
});

app.MapPut("/api/componentes/{id:int}", (int id, ComponenteDto actualizado) =>
{
    var item = componentes.FirstOrDefault(c => c.ID == id);
    if (item is null) return Results.NotFound();

    item.Nombre = actualizado.Nombre;
    item.Categoria = actualizado.Categoria;
    item.Marca = actualizado.Marca;
    item.Precio = actualizado.Precio;
    item.Stock = actualizado.Stock;
    item.Descripcion = actualizado.Descripcion;
    if (!string.IsNullOrEmpty(actualizado.Imagen))
    {
        item.Imagen = actualizado.Imagen;
    }

    return Results.Ok(item);
});

app.MapDelete("/api/componentes/{id:int}", (int id) =>
{
    var item = componentes.FirstOrDefault(c => c.ID == id);
    if (item is null) return Results.NotFound();
    componentes.Remove(item);
    return Results.NoContent();
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");

public class ComponenteDto
{
    public int ID { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public double Precio { get; set; }
    public int Stock { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public string Imagen { get; set; } = string.Empty;
}
