namespace LinkedListProject
{
    public class LinkedListItem
    {
        public LinkedListItem Next;
        public LinkedListItem Previous;

        public object Data;

        public LinkedListItem(object Data)
        {
            this.Data = Data;
        }
    }
}
