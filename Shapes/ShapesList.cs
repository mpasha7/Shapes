using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class ShapesList : IList<IShape>
    {
        private readonly List<IShape> _shapes;

        public ShapesList()
        {
            _shapes = new List<IShape>();
        }

        public ShapesList(IShape shape)
        {
            _shapes = new List<IShape> { shape };
        }

        public ShapesList(List<IShape> shapes)
        {
            _shapes = new List<IShape>(shapes);
        }

        public IShape this[int index] 
        {
            get
            {
                try
                {
                    return _shapes[index];
                }
                catch (global::System.Exception)
                {
                    Console.WriteLine("Индекс выходит за пределы списка!");
                    return null;
                }
            }
            set => throw new NotImplementedException(); 
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(IShape item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IShape item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IShape[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IShape> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(IShape item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, IShape item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IShape item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
