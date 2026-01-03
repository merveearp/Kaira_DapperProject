using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.ContactDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.ContactRepositories
{
    public class ContactRepository(AppDbContext context) : IContactRepository
    {

        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<UpdateContactDto> GetAsync()
        {
            var query = "Select * From Contacts";
            return await _db.QueryFirstOrDefaultAsync<UpdateContactDto>(query);
        }

        public async Task UpdateAsync(UpdateContactDto updateDto)
        {
            var query = "Update Contacts set Address=@Address, PhoneNumber=@PhoneNumber ,Info=@Info , Email=@Email where ContactId=@ContactId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }

}