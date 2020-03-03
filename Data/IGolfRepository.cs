using System.Collections.Generic;
using System.Threading.Tasks;
using GolfClub.API.Models;
using GolfClub.API.DTOs;

namespace GolfClub.API.Data
{
    public interface IGolfRepository
    {
         Task<IEnumerable<Reservation>> GetReservations(int id);
         Task<List<TeeTime>> GetTeeTimes();
         Task<bool> AddReservation(reservationDTO resdata);
         Task Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll(); 
         void SaveChanges();
    }
}