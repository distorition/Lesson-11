using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._1
{



    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }



class Program:ILinkedList
    {

        static void Main(string[] args)
        {

        }

        public void AddNode(int value)
        {

            Node node = new Node();
            var NewNode = new Node { Value = value };
            node.NextNode = NewNode;
          
        }

        public void AddNodeAfter(Node node, int value)
        {
            var usnode = node;
            while(node.Value==value)
            {
                usnode = usnode.NextNode;
            }
            var newNode = new Node { Value = value };
            usnode.NextNode = newNode;


        }

        public Node FindNode(int searchValue)
        {
            Node node = new Node();

            while(node!=null)
            {
                if(node.Value==searchValue)
                {
                    return node;
                }
                node = node.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            var StarNode = new Node();
            var curNode = StarNode;
            int count = 0;
            while (curNode != null)
            {
                count++;
                curNode = curNode.NextNode;
            }
            return count;
        }

        public void RemoveNode(int index)
        {
            int curIndex = 0;
            var currNode = new Node();
            while(currNode!=null)
            {
                if(curIndex==index-1)
                {
                    RemoveNode(currNode);
                }
                currNode = currNode.NextNode;
                curIndex++;
            }

        }

        public void RemoveNode(Node node)
        {
           if(node.NextNode==null)
            {
                return;
            }
            var Nexnod = node.NextNode.NextNode;
            node.NextNode = Nexnod;
        }
    }
}
