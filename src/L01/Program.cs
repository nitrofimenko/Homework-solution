using L01;

Address instance = new Address();
instance.Index = "08720";
instance.Country = "Krakozia";
instance.City = "Default";
instance.Street = "Main Street";
instance.House = "221B";
instance.Apartment = "Penthouse";
Console.WriteLine($"Index\t\t{instance.Index}\n" +
    $"Country\t\t{instance.Country}\n" +
    $"City\t\t{instance.City}\n" +
    $"Street\t\t{instance.Street}\n" +
    $"House\t\t{instance.House}\n" +
    $"Apartment\t{instance.Apartment}\n");