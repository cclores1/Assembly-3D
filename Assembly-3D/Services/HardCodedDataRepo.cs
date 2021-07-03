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


            partList.Add(new PartsModel { Id = 0, Name = "Duck", Description = "Duck" });
            partList.Add(new PartsModel { Id = 1, Name = "Dog", Description = "Dog" });
            partList.Add(new PartsModel { Id = 0, Name = "Cat", Description = "Cat" });
            partList.Add(new PartsModel { Id = 1, Name = "Bat", Description = "Bat" });
            partList.Add(new PartsModel { Id = 0, Name = "Hamster", Description = "Hamster" });
            partList.Add(new PartsModel { Id = 1, Name = "Tilapia", Description = "Tilapia" });
            partList.Add(new PartsModel { Id = 0, Name = "Eagle", Description = "Eagle" });
            partList.Add(new PartsModel { Id = 1, Name = "Squirrel", Description = "Squirrel" });
            partList.Add(new PartsModel { Id = 0, Name = "Lamb", Description = "Lamb" });
            partList.Add(new PartsModel { Id = 1, Name = "Sheep", Description = "Sheep" });
            partList.Add(new PartsModel { Id = 0, Name = "Dolphin", Description = "Dolphin" });
            partList.Add(new PartsModel { Id = 1, Name = "Tiger", Description = "Tiger" });


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
