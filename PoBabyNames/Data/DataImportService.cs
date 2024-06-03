using CsvHelper;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using PoBabyNames.Data;
using System.IO;
using CsvHelper.Configuration;
using PoBabyNames.Models;

public class DataImportService
{
    private readonly ApplicationDbContext _dbContext;

    public DataImportService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task ClearNamesTableAsync()
    {
        _dbContext.Names.RemoveRange(_dbContext.Names);
        await _dbContext.SaveChangesAsync();
    }

    //public async Task ImportCsvDataAsync(Stream fileStream)
    //{
    //    try
    //    {
    //        await ClearNamesTableAsync();  // Clear the table before importing new data

    //        using var reader = new StreamReader(fileStream);
    //        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true });
    //        var records = csv.GetRecords<Name>().ToList(); // Convert to List to catch any parsing errors
    //        if (records.Any())
    //        {
    //            _dbContext.Names.AddRange(records);
    //            await _dbContext.SaveChangesAsync();
    //        }
    //        else
    //        {
    //            Console.WriteLine("No records found to import.");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"An error occurred: {ex.Message}");
    //    }
    //}

    //public async Task ImportCsv(Stream fileStream)
    //{
    //    await ImportCsvDataAsync(fileStream);
    //}






    public async Task ImportCsvDataAsync()
    {
        try
        {
            await ClearNamesTableAsync();  // Clear the table before importing new data

            // string filePath = "NationalNames.csv";
            string filePath = "names100.csv";

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true });
            var records = csv.GetRecords<Name>().ToList(); // Convert to List to catch any parsing errors
                                                           // var records = csv.GetRecords<Name>().Take(10).ToList(); // Fetch only the first 10 records
            if (records.Any())
            {
                _dbContext.Names.AddRange(records);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("No records found to import.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public async Task ImportCsv()
    {
        await ImportCsvDataAsync();
    }
}
