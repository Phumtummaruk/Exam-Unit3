using System;

class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

class Task3
{
    static void Main(string[] args)
    {
        Node root = new Node
        {
            Value = 325,
            Left = new Node
            {
                Value = 20,
                Right = new Node
                {
                    Value = 37,
                    Left = new Node
                    {
                        Value = 717,
                        Left = new Node
                        {
                            Value = 993,
                            Left = new Node
                            {
                                Value = 982,
                                Left = new Node
                                {
                                    Value = 675,
                                    Right = new Node { Value = 53 }
                                },
                                Right = new Node
                                {
                                    Value = 307,
                                    Left = new Node
                                    {
                                        Value = 530,
                                        Left = new Node
                                        {
                                            Value = 621,
                                            Right = new Node { Value = 385 },
                                            Left = new Node
                                            {
                                                Value = 270,
                                                Left = new Node
                                                {
                                                    Value = 764,
                                                    Right = new Node { Value = 352 }
                                                }
                                            }
                                        }
                                    },
                                    Right = null
                                }
                            }
                        }
                    }
                }
            },
            Right = new Node
            {
                Value = 447,
                Left = new Node { Value = 886 },
                Right = new Node
                {
                    Value = 274,
                    Left = new Node
                    {
                        Value = 307,
                        Left = new Node
                        {
                            Value = 474,
                            Left = new Node
                            {
                                Value = 471,
                                Left = new Node
                                {
                                    Value = 752,
                                    Left = new Node
                                    {
                                        Value = 228,
                                        Left = new Node
                                        {
                                            Value = 904,
                                            Left = new Node
                                            {
                                                Value = 727,
                                                Left = new Node
                                                {
                                                    Value = 181,
                                                    Right = new Node { Value = 639 }
                                                }
                                            }
                                        }
                                    },
                                    Right = new Node { Value = 879 }
                                }
                            }
                        }
                    }
                }
            }
        };

        int sum = CalculateSum(root);
        int deepestLevel = FindDeepestLevel(root);
        int numberOfNodes = CountNodes(root);

        Console.WriteLine($"Sum of the full structure: {sum}");
        Console.WriteLine($"Deepest level of the structure: {deepestLevel}");
        Console.WriteLine($"Number of nodes: {numberOfNodes}");
    }

    static int CalculateSum(Node node)
    {
        if (node == null)
            return 0;

        return node.Value + CalculateSum(node.Left) + CalculateSum(node.Right);
    }

    static int FindDeepestLevel(Node node)
    {
        if (node == null)
            return 0;

        int leftDepth = FindDeepestLevel(node.Left);
        int rightDepth = FindDeepestLevel(node.Right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }

    static int CountNodes(Node node)
    {
        if (node == null)
            return 0;

        return 1 + CountNodes(node.Left) + CountNodes(node.Right);
    }
}