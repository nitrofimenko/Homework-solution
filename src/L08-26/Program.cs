Console.Write("Date of Birth: ");
DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine()).Date;
Console.WriteLine(dateOfBirth.AddYears(DateTime.Now.Date.Year - dateOfBirth.Year) > DateTime.Now.Date ?
    (dateOfBirth.AddYears(DateTime.Now.Date.Year - dateOfBirth.Year) - DateTime.Now.Date).Days :
    (dateOfBirth.AddYears(DateTime.Now.Date.Year + 1 - dateOfBirth.Year) - DateTime.Now.Date).Days);