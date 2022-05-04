//using System;
//using System.Linq;
//using System.Collections.Generic;

//namespace Programmers
//{
//    class StackQueue_2
//    {
//        static void Main()
//        {
//            var output = Solution.solution(new int[] { 1, 1, 9, 1, 1, 1 }, 0);
//            Console.WriteLine(output);
//            Console.ReadKey();
//        }
//    }

//    public class Solution
//    {
//        public static int solution(int[] priorities, int location)
//        {
//            Queue nodeQueue = new Queue();
//            int dequeueCount = 0;

//            // 큐에 입력하는 부분
//            for (int i = 0; i < priorities.Length; i++)
//            {
//                nodeQueue.Enqueue(new Node(priorities[i], i));
//            }

//            while (true)
//            {
//                if (nodeQueue.SearchThanBigger(nodeQueue.Front.Priority))
//                {
//                    nodeQueue.Enqueue(nodeQueue.Dequeue());
//                }
//                else
//                {
//                    var node = nodeQueue.Dequeue();
//                    dequeueCount++;

//                    if (node.Order == location)
//                    {
//                        return dequeueCount;
//                    }
//                }
//            }
//        }
//    }

//    public class Queue
//    {
//        List<Node> nodeList;
//        public int Count { get { return nodeList.Count; } }
//        public Node Front { get { return nodeList[0]; } }

//        public Queue()
//        {
//            nodeList = new List<Node>();
//        }

//        public void Enqueue(Node newNode)
//        {
//            nodeList.Add(newNode);
//        }

//        public Node Dequeue()
//        {
//            var node = nodeList[0];
//            nodeList.RemoveAt(0);
//            return node;
//        }

//        public Node Peek()
//        {
//            return nodeList[0];
//        }

//        public bool SearchThanBigger(int priority)
//        {
//            return nodeList.Any(node => priority < node.Priority);
//        }
//    }

//    public struct Node
//    {
//        public int Priority { get; private set; }
//        public int Order { get; private set; }

//        public Node(int priority, int order)
//        {
//            Priority = priority;
//            Order = order;
//        }
//    }
//}
