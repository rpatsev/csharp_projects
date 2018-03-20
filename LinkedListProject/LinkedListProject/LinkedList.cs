using System;

namespace LinkedListProject
{
    public class MyLinkedList
    {
        public LinkedListItem Current;
        public LinkedListItem First;
        public int Length;

        public LinkedListItem Next { get; private set; }

        public void Add(object item)
        {

            var newListElement = new LinkedListItem(item);

            if (First == null)
            {
                First = newListElement;
                Current = newListElement;
            }

            Current.Next = newListElement;
            newListElement.Previous = Current;
            Current = newListElement;
            Length++;
            
        }

        public void Insert(object item, int position)
        {
            var newListElement = new LinkedListItem(item);

            LinkedListItem current = First;

            for (int i = 0; i < position; i++)
            {
                if (i == position)
                {
                    if(current != null)
                    {

                    }
                    else
                    {
                        Add(item);
                    }
                }
                else
                {

                }
            }
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

            Length--;
        }

        public void Clear()
        {
            Current = null;
            First = null;
            Length = 0;
        }

        public void DisplayLinkedList()
        {
            LinkedListItem item = First;
            while(item != null)
            {
                Console.WriteLine(item.Data);
                item = item.Next;
            }
        }

    }
}
