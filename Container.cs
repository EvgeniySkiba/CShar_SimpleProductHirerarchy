using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace lab03
{
    public class Container
    {
        private const int SIZE = 5;
        private Product[] container;
        private int lastIndex;

        public Container()
        {
           lastIndex = 0;
           container = new Product[SIZE];
        }

        /// <summary>
        ///  метод добавления объекта в контейнер
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            container[lastIndex] = product;
            lastIndex++;
        }

        /// <summary>
        /// метод удаления объекта из контейнера по индексу
        /// </summary>
        /// <param name="index"></param>
        public void deleteByIndex(int index)
        {
           
            int j = 0;
            Product[] temp = new Product[SIZE];
            for (var i = 0; i < container.Length;i++)
            {
                if (i != index)
                    temp[j] = container[i];
            }

            container = new Product[SIZE];

            for(var i = 0; i< temp.Length; i++)
            {
                container[i] = temp[i];
            }

        }


        /// <summary>
        /// вспомагательный внутренний мметод взять по индексу 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Product getByIndex(int index)
        {
            Product product = null;

            // если контейнер не создан или пуст 
            if (container == null || container.Length < 1)
                return product;

            /// если заданный индекс за пределами 
            if (index < 0 || index > container.Length)
                return product;

            product = container.ElementAt(index);

            return product;               
        }

        public void Sort()
        {
            Array.Sort(container);            
        }

        public override string ToString()
        {
            /// строки неизменяемый объект 
            int i = 1;
            StringBuilder builder = new StringBuilder();

            /// поэтому собираем строку таким образом 
            /// иначе каждый раз новый объект и это черевато расходом памяти 
            foreach (var item in container)
            {
                builder.Append("current : ");
                builder.Append(i.ToString());
                builder.Append(", ");
                builder.Append("Name : ");
                builder.Append(item.Name);
                builder.Append(", ");
                builder.Append("Price : ");
                builder.Append(item.Price);
                builder.Append("\n");

                i++;
            }

            // возвращаем строку 
            return builder.ToString();
        }

    }
}