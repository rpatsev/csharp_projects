using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    public class MyLinkedList
    {
        public LinkedListItem Current;
        public LinkedListItem First;

        public void Add(object item)
        {

            var newListElement = new LinkedListItem
            {
                Data = item
            };

            if (First == null)
            {
                First = newListElement;
            }

            Current.Next = newListElement;
            newListElement.Previous = Current;
            Current = newListElement;
            
        }

        public void Remove(object itemToRemove)
        {

            LinkedListItem current = First;

            while (current != null)
            {
                if(object.ReferenceEquals(current.Data, itemToRemove))
                {
                    if (current == this.First)
                    {
                        this.First = this.First.Next;
                    }
                    else
                    {
                        current.Previous = current.Next;
                    }

                    
                    current = null;
                    break;
                }

                current = current.Next;
            }
        }

    }
}
