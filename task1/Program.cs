class HashTable
{
    public ListNode[] values;

    public HashTable(int size)
    {
        values = new ListNode[size];
    }
    public void Insert(int newValue)
    {
        int index = newValue % values.Length;
        if (values[index] == null)
        {
            values[index] = new ListNode(newValue);
        }
        else
        {
            ListNode node = values[index];
            while (node.next != null)
            {
                node = node.next;
            }
            node.next = new ListNode(newValue);
        }
    }
    public void Print()
    {
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write(i + ": ");
            ListNode node = values[i];
            while (node != null)
            {
                Console.Write(node.value + "");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
class ListNode
{
    public int value;
    public ListNode next;

    public ListNode(int value)
    {
        this.value = value;

    }
}
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        HashTable table = new HashTable(n);
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < input.Length; i++)
        {
            int value = int.Parse(input[i]);
            table.Insert(value);
        }
        table.Print();
    }
}