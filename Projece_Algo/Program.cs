using System;
using System.Text;

class Node
{
    public Note Data { get; set; }
    public Node Next { get; set; }

    public Node(Note data)
    {
        Data = data;
        Next = null;
    }
}
