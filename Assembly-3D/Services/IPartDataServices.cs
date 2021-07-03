using Assembly_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Services
{
    interface IPartDataServices
    {
        List<PartsModel> GetAllPart();

        List<PartsModel> SearchParts(string searchTerm);

        PartsModel GetPartsById(int Id);

        int Insert(PartsModel parts);

        int Delete(PartsModel parts);

        int Update(PartsModel parts);

    }


}
