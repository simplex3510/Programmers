//using System;
//using System.Collections.Generic;

//namespace Programmers
//{
//    internal class StackQueue_1
//    {
//        static void Main()
//        {
//            //Solution solution = new Solution();
//            var inputs = Solution.solution(new int[] { 95, 90, 99, 99, 80, 99 }, new int[] { 1, 1, 1, 1, 1, 1 });

//            foreach (var input in inputs)
//            {
//                Console.WriteLine($"{input.ToString()} ");
//            }

//            Console.ReadKey();
//        }
//    }

//    class Solution
//    {
//        public static int[] solution(int[] progresses, int[] speeds)
//        {
//            Queue nodeQueue = new Queue();
//            List<int> outputs = new List<int>();

//            for (int i = 0; i < progresses.Length; i++)
//            {
//                nodeQueue.Enqueue(new Node(progresses[i], speeds[i]));
//            }

//            while (nodeQueue.Count != 0)
//            {
//                nodeQueue.NextDay();
//                var output = nodeQueue.Dequeue();
//                if (output == 0)
//                {
//                    continue;
//                }
//                else
//                {
//                    outputs.Add(output);
//                }
//            }

//            return outputs.ToArray();
//        }
//    }

//    public class Queue
//    {

//        private List<Node> nodeList;
//        public int Count { get { return nodeList.Count; } }

//        public Queue()
//        {
//            nodeList = new List<Node>();
//        }

//        public void Enqueue(Node newNode)
//        {
//            nodeList.Add(newNode);
//        }

//        public int Dequeue()
//        {
//            int dequeueCount = 0;

//            for (int i = 0; i < Count; i++)
//            {
//                if (nodeList[i].Progress < 100)
//                {
//                    break;
//                }
//                else
//                {
//                    nodeList.RemoveAt(i);
//                    i--;
//                    dequeueCount++;
//                }
//            }

//            return dequeueCount;
//        }

//        public void NextDay()
//        {
//            for (int i = 0; i < Count; i++)
//            {
//                nodeList[i].Update();
//            }
//        }
//    }

//    public class Node
//    {
//        public int Progress { get; private set; }
//        public int Speed { get; private set; }

//        public Node(int progress, int speed)
//        {
//            Progress = progress;
//            Speed = speed;
//        }

//        public void Update()
//        {
//            Progress += Speed;
//        }
//    }
//}
