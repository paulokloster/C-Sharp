/* ______        ______  ____   ___  _  _     ____        _          ____  _                   _                          ___        _    _                  _ _   _                   
  / ___\ \      / /  _ \| ___| / _ \| || |   |  _ \  __ _| |_ __ _  / ___|| |_ _ __ _   _  ___| |_ _   _ _ __ ___  ___   ( _ )      / \  | | __ _  ___  _ __(_) |_| |__  _ __ ___  ___ 
  \___ \\ \ /\ / /| | | |___ \| | | | || |_  | | | |/ _` | __/ _` | \___ \| __| '__| | | |/ __| __| | | | '__/ _ \/ __|  / _ \/\   / _ \ | |/ _` |/ _ \| '__| | __| '_ \| '_ ` _ \/ __|
   ___) |\ V  V / | |_| |___) | |_| |__   _| | |_| | (_| | || (_| |  ___) | |_| |  | |_| | (__| |_| |_| | | |  __/\__ \ | (_>  <  / ___ \| | (_| | (_) | |  | | |_| | | | | | | | \__ \
  |____/  \_/\_/  |____/|____/ \___/   |_|   |____/ \__,_|\__\__,_| |____/ \__|_|   \__,_|\___|\__|\__,_|_|  \___||___/  \___/\/ /_/   \_\_|\__, |\___/|_|  |_|\__|_| |_|_| |_| |_|___/
    C# program to demonstrate insert operation in binary search tree                                                                        |___/       Paulo ID 764700963@nzse.ac.nz
                                                                                    
using System;

class BinarySearchTree
{

    // Class containing left and right child of current node and key value
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    //Root of BST
    Node root;

    //Constructor
    BinarySearchTree()
    {
        root = null;
    }


    //This method mainly calls insertRec()
    void insert(int key)
    {
        root = insertRec(root, key);
    }

    //A recursive function to insert a new key in BST
    Node insertRec(Node root, int key)
    {

        //If the tree is empty, return a new node

        if (root == null)
        {
            root = new Node(key);
            return root;
        }

        //Otherwise, recur down the tree
        if (key < root.key)
            root.left = insertRec(root.left, key);
        else if (key > root.key)
            root.right = insertRec(root.right, key);

        return root;
    }
    //-------------------------------
    //This method mainly calls InorderRec()
    void inorder()
    {
        inorderRec(root); //Calling function below and execute it
    }

    //A utility function to do inorder traversal of BST
    void inorderRec(Node root) //root = node
    {
        if (root != null)
        {
            inorderRec(root.left);
            Console.WriteLine(root.key);
            inorderRec(root.right);
        }
    }
    //-----------------------------------
    //This method mainly calls preorderRec()
    void preorder()
    {        
        preorderRec(root);  //Calling function below and execute it
    }

    //A utility function to do preorder traversal of BST
    void preorderRec(Node root)
    {
        if (root != null)
        {
            Console.WriteLine(root.key);
            preorderRec(root.left);
            preorderRec(root.right);
        }
    }

    //--------------------------------------
    //This method mainly calls postorderRec()
    void postorder()
    {
        postorderRec(root);
    }

    //A utility function to do postorder traversal of BST
    void postorderRec(Node root)
    {
        if (root != null)
        {
            postorderRec(root.left);
            postorderRec(root.right);
            Console.WriteLine(root.key);
        }
    }


    //Driver Code---------------------------------
    public static void Main(String[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
        int userInput;

        //creating variable for user to input values

        /*
         Let us create following BST
               50
              /   \
            30     70
           / \     / \
         20  40   60  80 

        */


        tree.insert(50);
        tree.insert(30);
        tree.insert(20);
        tree.insert(40);
        tree.insert(70);
        tree.insert(70);
        tree.insert(80);

       /* // Print inorder traversal of the BST
        tree.inorder();

        // Print inorder traversal of the BST
        tree.preorder();

        // Print inorder traversal of the BST
        tree.postorder();*/


        Console.Write("PLEASE CHOOSE OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
        userInput = Convert.ToInt32(Console.ReadLine());
        
        while(userInput != 0)
        {
            switch (userInput)
            {
                case 1:     //Adding elements into the tree

                    Console.Write("Option 1 selected is 1-InOrder: ");                 
                    
                    // Print inorder traversal of the BST
                    tree.inorder(); //

                    Console.Write("\nPLEASE CHOOSE OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
                    break;

                case 2:

                    Console.Write("Option 2 selected is 2-PreOrder: ");

                    // Print inorder traversal of the BST
                    tree.preorder();

                    Console.Write("\nPLEASE CHOOSE OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
                    break;

                case 3:

                    Console.Write("Option 3 selected is 3-PostOrder:  ");

                    // Print inorder traversal of the BST
                    tree.postorder();

                    Console.Write("\nPLEASE CHOOSE OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
                    break;

                default:
                    Console.WriteLine("\nOption 4 selected to exit the program! bye! ");
                    //Console.ReadKey();  
                    break;
            }
            if (userInput == 4) break;
            userInput = Convert.ToInt32(Console.ReadLine());
        }
    }
}