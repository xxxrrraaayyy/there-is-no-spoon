﻿using System.Collections;
using System.Collections.Generic;
using MethodsLibrary.Objects;

namespace Methods.Tests.Objects
{
    /// <summary>
    /// Define different inputs for testing
    /// contains different data structures 
    /// </summary>
    public class TestData
    {

        //private IList dataList; 

        //public TestData() { }

        //public string[] DataString(string[] strings)
        //{
        //    this.dataList = new List<string>();
        //}

        /// <summary>
        /// Gets or sets a string type input for testing
        /// </summary>
        public string InputString { get; set; }

        /// <summary>
        /// Gets or sets a string type output for testing
        /// </summary>
        public string OutputString { get; set; }

        /// <summary>
        /// Gets or sets an array with int type as input for testing
        /// </summary>
        public int[] InputArrayInt { get; set; }

        /// <summary>
        /// Gets or sets an array with int type as output for testing
        /// </summary>
        public int[] OutputArrayInt { get; set; }

        /// <summary>
        /// Gets or sets a int type input for testing
        /// </summary>
        public int InputInt { set; get; }

        /// <summary>
        /// Gets or sets a int type output for testing
        /// </summary>
        public int OutputInt { set; get; }

        /// <summary>
        /// Gets or sets value for singly-linked list input
        /// </summary>
        public ListNode InputListNode { set; get; }

        /// <summary>
        /// Gets or sets value for singly-linked list output
        /// </summary>
        public ListNode OutputListNode { set; get; }


        /// <summary>
        /// Initialized values for input list from a given array (nullable)
        /// </summary>
        /// <param name="arrayInts"> Nullable input array </param>
        /// <returns> The head of the input list </returns>
        public ListNode InputList(int?[] arrayInts)
        {
            if (arrayInts == null)
            {
                return null;
            }

            ListNode initializeListNode = new ListNode();
            ListNode head = initializeListNode;

            foreach (int number in arrayInts)
            {
                initializeListNode.Next = new ListNode(number);
                initializeListNode = initializeListNode.Next;
            }
            return head.Next;
        }

        /// <summary>
        /// Initialized values for output list from a given array (nullable)
        /// </summary>
        /// <param name="arrayInts"> Nullable output array </param>
        /// <returns> The head of the output list </returns>
        public ListNode OutputList(int?[] arrayInts)
        {
            if (arrayInts == null)
            {
                return null;
            }

            ListNode initializeListNode = new ListNode();
            ListNode head = initializeListNode;

            foreach (int number in arrayInts)
            {
                initializeListNode.Next = new ListNode(number);
                initializeListNode = initializeListNode.Next;
            }
            return head.Next;
        }


    }
}
