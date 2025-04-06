internal class Program
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    private static void Main(string[] args)
    {

    }
    //НЕ ЭФЕКТИВНОЕ
    //public bool HasCycle(ListNode head)
    //{
    //    if (head == null)
    //        return false;
    //    HashSet<ListNode> links = new();
    //    ListNode ptr= head;
    //    while (ptr.next != null)
    //    {
    //        if (links.Contains(ptr))
    //            return true;
    //        else 
    //            links.Add(ptr);
    //           ptr = head.next;
    //    }

    //    return false;
    //}
    public bool HasCycle2(ListNode head)
    {
        if (head == null)
            return false;
        else if (head.next == null) 
            return false;
        ListNode fastPtr = head;
        ListNode ptr = head;
        while (fastPtr.next != null && fastPtr.next.next != null)
        {
            fastPtr = fastPtr.next.next;
            ptr = ptr.next;
            if (fastPtr == ptr)
                return true;
        }

        return false;
    }
}