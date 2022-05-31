using System;
namespace CSharpHW4
{
	public interface IRepository<T> where T : Entity
	{
        public void Add(T item);

        public void Remove(T item);

        public void Save();

        public IEnumerable<T> GetAll();

        public T GetById(int id);
	}
}

