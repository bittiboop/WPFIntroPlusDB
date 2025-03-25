using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class RentTimeModel : IModel
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public RentTimeModel()
    {
        
    }
    public RentTimeModel(int id, DateTime startDate)
    {
        Id = id;
        StartDate = startDate;
    }
    public RentTimeModel(int id, DateTime startDate, DateTime? endDate)
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
    }
}