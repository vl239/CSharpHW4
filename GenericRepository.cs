using System;

namespace CSharpHW4
{
    public class GenericRepository : IRepository<Entity>
    {
        List<Entity> lstEntity = new List<Entity>();

        public void Add(Entity item)
        {
            lstEntity.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return lstEntity;
        }

        public Entity GetById(int id)
        {
            for (int i = 0; i < lstEntity.Count; i++)
            {
                if (lstEntity[i].Id == id)
                {
                    return lstEntity[i];
                }
            }
            return null;
        }

        public void Remove(Entity item)
        {
            lstEntity.Remove(item);
        }

        public void Save()
        {
            
        }
    }
}

