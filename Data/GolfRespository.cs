using System.Threading.Tasks;
using GolfClub.API.Models;
using GolfClub.API.DTOs;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using System;
using GolfClubAPI.DTOs;

namespace GolfClub.API.Data
{
    public class GolfRespository : IGolfRepository
    {
        private readonly DataContext _context;
        public GolfRespository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddReservation(reservationDTO resdata)
        {
            try
            {
                var res = new Reservation
                {
                    UserID = resdata.id,
                    ReservationTypeID = resdata.reservationType,
                    noOfPlayers = resdata.noOfPlayer,
                    approval = resdata.approval,
                    subject = resdata.subject,
                    startTime = resdata.startDate,
                    endTime = resdata.endDate,
                    score = 0,
                    recurringData = resdata.recurringData,
                };
                await _context.Reservations.AddAsync(res);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            // using (TransactionScope scope = new TransactionScope())
            // {
            //     try {
            
            //     var res = new Reservation
            //     {
            //         UserID = resdata.id,
            //         ReservationTypeID = resdata.reservationType,
            //         NumberOfPlayers = resdata.noOfPlayer,
            //         approved = resdata.approvalStatus,
            //     };
                
            //     await _context.AddAsync(res);
            //     await _context.SaveChangesAsync();

            //     var tee = new TeeTime
            //     {
            //         ReservationId = res.ReservationId,
            //         Subject = resdata.subject,
            //         StartTime = resdata.startDate,
            //         EndTime = resdata.endDate,
            //         score = 0,
            //         RecurrenceRule = resdata.recurringData,
            //     };

            //     await _context.AddAsync(tee);
            //     var result = await _context.SaveChangesAsync();
            //     scope.Complete();
            //     if (result > 0) 
            //         return true;
            //     return false;
            //     }
            // catch(Exception ex)
            // {
            //     throw ex;
            // }
        }

        public async Task<bool> ApproveReservation(approvalDTO approvalData)
        {
            try {
                var query = (from q in _context.Reservations
							where q.id == approvalData.id
							select q).First();
				query.approval = approvalData.approval;
				await _context.SaveChangesAsync();
				return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> RemoveReservation(int id){
            try
            {
                var res = _context.Reservations.Find(id);
                _context.Reservations.Remove(res);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<Reservation>> GetReservations(int id)
        {
            var reservations = await _context.Reservations.Where(u => u.UserID == id).ToListAsync();
            return reservations;
        }

        public async Task<List<Reservation>> GetTeeTimes()
        {
            var tee = await _context.Reservations.ToListAsync();
            return tee;
        }

        public async Task<List<Reservation>> GetTeeTimesById(int id)
        {
            var tee = await _context.Reservations.Where(x => x.UserID == id).ToListAsync();
            return tee;
        }

        public async Task Add<T>(T entity) where T : class
        {
            await _context.AddAsync(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}