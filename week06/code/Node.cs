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
        else if (value > Data)
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
        if (value < Data)
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        else if (value > Data)
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        return true;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left is null)
            if (Right is null)
                return 1;
            else
                return 1 + Right.GetHeight();
        else if (Right is null)
            return 1 + Left.GetHeight();
        return 1 + Math.Max(Left.GetHeight(), Right.GetHeight());
    }
}