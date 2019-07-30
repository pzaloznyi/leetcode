namespace MergeKSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode[] lists =
            {
                new ListNode(1) {next = new ListNode(4) {next = new ListNode(5)}},
                new ListNode(1) {next = new ListNode(3) {next = new ListNode(4)}},
                new ListNode(2) {next = new ListNode(6)}
            };
            var mergeKLists = new Solution().MergeKLists(lists);
        }
    }

    public class Solution
    {
        private ListNode MergeSortedLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.val >= list2.val)
            {
                list2.next = MergeSortedLists(list2.next, list1);
                return list2;
            }

            list1.next = MergeSortedLists(list1.next, list2);

            return list1;
        }
        
        private ListNode MergeKLists(ListNode[] lists, int start, int end)
        {
            if (start > end)
                return null;
            if (start == end)
                return lists[start];

            int middle = (end + start) / 2;
            var left = MergeKLists(lists, start, middle);
            var right = MergeKLists(lists, middle + 1, end);
            return MergeSortedLists(left, right);
        }
        
        public ListNode MergeKLists(ListNode[] lists)
        {
            return MergeKLists(lists, 0, lists.Length - 1);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}