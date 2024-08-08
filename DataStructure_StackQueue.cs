public class DataStructure_StackQueue
{
    private Queue<int> q1;
    private Queue<int> q2;

    public DataStructure_StackQueue()
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }

    public void Push(int value)
    {
        q1.Enqueue(value);
    }

    public int Pop()
    {
        if (q1.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }

        int top = q1.Dequeue();

        // swap the queue
        (q2, q1) = (q1, q2);
        return top;
    }

    public int Top()
    {
        if (q1.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }

        int top = q1.Peek();

        // swap the queue
        (q2, q1) = (q1, q2);
        return top;
    }
}