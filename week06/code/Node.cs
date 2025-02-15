public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                
                Left.Insert(value);
                
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
            
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        Node? current = this;

        while (current != null)
        {
            if (current.Data == value)
                return true;

            if (value < current.Data)
                current = current.Left;
            else
                current = current.Right;
        }

        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (this == null ){
            return 0;
        }

        int leftHeight = (Left != null) ? Left.GetHeight() : 0;
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;

        return Math.Max(leftHeight, rightHeight) + 1; // Replace this line with the correct return statement(s)
    }
}   