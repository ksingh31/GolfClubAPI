using System.Collections.Generic;
using System.Threading.Tasks;
using GolfClub.API.Models;
using GolfClub.API.DTOs;
using GolfClubAPI.DTOs;

namespace GolfClub.API.Data
{
    public interface IGolfRepository
    {
         Task<IEnumerable<Reservation>> GetReservations(int id);
         Task<List<Reservation>> GetTeeTimes();
         Task<List<Reservation>> GetTeeTimesById(int id);
         Task<bool> AddReservation(reservationDTO resdata);
         Task<bool> ApproveReservation(approvalDTO approvalData);
         Task<bool> RemoveReservation(int id);
         Task Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         void SaveChanges();
    }
}