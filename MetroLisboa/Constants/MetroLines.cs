using MetroLisboa.Models;

namespace MetroLisboa.Constants;

public static class MetroLines
{
    public static List<Line> GetAll()
    {
        var green = GetGreenLine();
        var blue = GetBlueLine();
        var yellow = GetYellowLine();
        var red = GetRedLine();

        return [green, blue, yellow, red];
    }
    
    private static Line GetGreenLine()
    {
        var directions = new List<Direction>()
        {
            new() { Id = "50", Name = "Telheiras" },
            new() { Id = "54", Name = "Cais do Sodré" }
        };
        
        return new Line()
        {
            Name = "Verde",
            Directions = directions,
            Stations = new ()
            {
                new() { Id = "CS", Name = "Cais do Sodré", Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "BC", Name = "Baixa/Chiado",  Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "RO", Name = "Rossio",        Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "MM", Name = "Martim Moniz",  Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "IN", Name = "Intendente",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AN", Name = "Anjos",         Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AR", Name = "Arroios",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AM", Name = "Alameda",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AE", Name = "Areeiro",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "RM", Name = "Roma",          Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AL", Name = "Alvalade",      Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CG", Name = "Campo Grande",  Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "TE", Name = "Telheiras",     Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] }
            }
        };
    }
    
    private static Line GetBlueLine()
    {
        var directions = new List<Direction>()
        {
            new() { Id = "42", Name = "Santa Apolónia" },
            new() { Id = "33", Name = "Reboleira" }
        };
        
        return new Line()
        {
            Name = "Azul",
            Directions = directions,
            Stations = new()
            {
                new() { Id = "RB", Name = "Reboleira",           Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AS", Name = "Amadora Este",        Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AF", Name = "Alfornelos",          Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "PO", Name = "Pontinha",            Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CA", Name = "Carnide",             Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CM", Name = "Colégio Militar/Luz", Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AH", Name = "Alto dos Moinhos",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "LA", Name = "Laranjeiras",         Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "JZ", Name = "Jardim Zoológico",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "PE", Name = "Praça de Espanha",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "SS", Name = "São Sebastião",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "PA", Name = "Parque",              Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "MP", Name = "Marquês de Pombal",   Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AV", Name = "Avenida",             Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "RE", Name = "Restauradores",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "BC", Name = "Baixa/Chiado",        Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "TP", Name = "Terreiro do Paço",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "SP", Name = "Santa Apolónia",      Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] }
            }
        };
    }

    private static Line GetYellowLine()
    {
        var directions = new List<Direction>()
        {
            new() { Id = "48", Name = "Rato" },
            new() { Id = "43", Name = "Odivelas" }
        };
        
        return new Line()
        {
            Name = "Amarela",
            Directions = directions,
            Stations = new()
            {
                new() { Id = "OD", Name = "Odivelas",             Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "SR", Name = "Senhor Roubado",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AX", Name = "Ameixoeira",           Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "LU", Name = "Lumiar",               Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "QC", Name = "Quinta das Conchas",   Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CG", Name = "Campo Grande",         Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CU", Name = "Cidade Universitária", Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "EC", Name = "Entre Campos",         Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CP", Name = "Campo Pequeno",        Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "SA", Name = "Saldanha",             Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "PI", Name = "Picoas",               Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "MP", Name = "Marquês de Pombal",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "RA", Name = "Rato",                 Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] }
            }
        };
    }

    private static Line GetRedLine()
    {
        var directions = new List<Direction>()
        {
            new() { Id = "38", Name = "São Sebastião" },
            new() { Id = "60", Name = "Aeroporto" }
        };
        
        return new Line()
        {
            Name = "Vermelha",
            Directions = directions,
            Stations = new()
            {
                new() { Id = "AP", Name = "Aeroporto",     Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "EN", Name = "Encarnação",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "MO", Name = "Moscavide",     Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "OR", Name = "Oriente",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CR", Name = "Cabo Ruivo",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "OS", Name = "Olivais",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "CH", Name = "Chelas",        Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "BV", Name = "Bela Vista",    Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "OL", Name = "Olaias",        Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "AM", Name = "Alameda",       Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "SA", Name = "Saldanha",      Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] },
                new() { Id = "SS", Name = "São Sebastião", Platforms = [ new() { Direction = directions[0]}, new() { Direction = directions[1] } ] }
            }
        };
    }
}