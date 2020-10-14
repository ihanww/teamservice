using StatlerWaldorfCorp.TeamService.Models;
using System;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.TeamService.LocationClient
{
    public interface ILocationClient
    {
        Task<LocationRecord> GetLatestForMember(Guid memberId);
        Task<LocationRecord> AddLocation(Guid memberId, LocationRecord locationRecord);
    }
}