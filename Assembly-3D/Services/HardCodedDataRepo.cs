using Assembly_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Services
{
    public class HardCodedDataRepo : IPartDataServices
    {

        static List<PartsModel> partList = new List<PartsModel>();
       
        
        public int Delete(PartsModel parts)
        {
            throw new NotImplementedException();
        }

        public List<PartsModel> GetAllPart()
        {


            partList.Add(new PartsModel { Id = 0, Name = "Cog", Description = "Cog" });
            partList.Add(new PartsModel { Id = 1, Name = "Wheel", Description = "Wheel" });
            partList.Add(new PartsModel { Id = 2, Name = "Car", Description = "Car" });
            partList.Add(new PartsModel { Id = 3, Name = "House", Description = "House" });
            partList.Add(new PartsModel { Id = 4, Name = "Airplane", Description = "Airplane" });
            partList.Add(new PartsModel { Id = 5, Name = "Rocket", Description = "Rocket" });
            partList.Add(new PartsModel { Id = 6, Name = "Well", Description = "Well" });
            partList.Add(new PartsModel { Id = 7, Name = "Shoes", Description = "Shoes" });
            partList.Add(new PartsModel { Id = 8, Name = "Lamp", Description = "Lamp" });
            partList.Add(new PartsModel { Id = 9, Name = "Helicopter", Description = "Helicopter" });
            partList.Add(new PartsModel { Id = 10, Name = "3DPrinter", Description = "3DPrinter" });
            partList.Add(new PartsModel { Id = 11, Name = "Pen", Description = "Pen" });


            return partList;
        }

        internal static object getAllPart()
        {
            throw new NotImplementedException();
        }

        public PartsModel GetPartsById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(PartsModel parts)
        {
            throw new NotImplementedException();
        }

        public List<PartsModel> SearchParts()
        {
            throw new NotImplementedException();

        }

        public int Update(PartsModel parts)
        {
            throw new NotImplementedException();
        }

        public List<PartsModel> SearchParts(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
