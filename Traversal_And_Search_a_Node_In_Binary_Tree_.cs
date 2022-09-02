/* ______        ______  ____   ___  _  _     ____        _          ____  _                   _                          ___        _    _                  _ _   _                   
  / ___\ \      / /  _ \| ___| / _ \| || |   |  _ \  __ _| |_ __ _  / ___|| |_ _ __ _   _  ___| |_ _   _ _ __ ___  ___   ( _ )      / \  | | __ _  ___  _ __(_) |_| |__  _ __ ___  ___ 
  \___ \\ \ /\ / /| | | |___ \| | | | || |_  | | | |/ _` | __/ _` | \___ \| __| '__| | | |/ __| __| | | | '__/ _ \/ __|  / _ \/\   / _ \ | |/ _` |/ _ \| '__| | __| '_ \| '_ ` _ \/ __|
   ___) |\ V  V / | |_| |___) | |_| |__   _| | |_| | (_| | || (_| |  ___) | |_| |  | |_| | (__| |_| |_| | | |  __/\__ \ | (_>  <  / ___ \| | (_| | (_) | |  | | |_| | | | | | | | \__ \
  |____/  \_/\_/  |____/|____/ \___/   |_|   |____/ \__,_|\__\__,_| |____/ \__|_|   \__,_|\___|\__|\__,_|_|  \___||___/  \___/\/ /_/   \_\_|\__, |\___/|_|  |_|\__|_| |_|_| |_| |_|___/
                                                                                                                                            |___/                                                                                            
    C# program to demonstrate insert operation in binary search tree
    This code check node inside the tree... if check if contains the elements ...example numbers inside the tree and shows message true or false after displaying all elements in the tree
 
    This code can find a node inside Binary Tree with pre defines values inside binary tree
    Missing change pre-define values to asking user input for searching a node inside the tree
*/
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
    void inorder() //IN ORDER
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
    void preorder() //PRE ORDER
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
    void postorder() //POST ORDER
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
    //-----------------------------
    bool ifNodeExist(int n) //IF NODE EXISTS
    {
        return ifNodeExists(root, n);
    }

    // Function to traverse the tree in preorder
    // and check if the given node exists in it
    static bool ifNodeExists(Node node, int key) //Node will hold the root value, Key will hold the user input value
    {
        if (node == null)
            return false;

        if (node.key == key)
            return true;

        // then recur on left subtree /
        bool res1 = ifNodeExists(node.left, key);

        // node found, no need to look further
        if (res1) return true;

        // node is not found in left,
        // so recur on right subtree /
        bool res2 = ifNodeExists(node.right, key);

        return res2;
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

        //Tree with pre defines values
        tree.insert(50);
        tree.insert(30);
        tree.insert(20);
        tree.insert(40);
        tree.insert(70);
        tree.insert(70);
        tree.insert(80);

        /* 
         
         // Print inorder traversal of the BST
         tree.inorder(); //This is commented now because i move this to inside the case 1

         // Print inorder traversal of the BST
         tree.preorder(); //This is commented now because i move this to inside the case 2

         // Print inorder traversal of the BST
         tree.postorder(); //This is commented now because i move this to inside the case 3
                
         */
        
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("                 SEARCH A NODE IN BINARY TREE");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("________________________________________________________________");
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("\nPlease select option: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
        userInput = Convert.ToInt32(Console.ReadLine());

        while (userInput != 0)
        {
            switch (userInput)
            {
                case 1:     //Adding elements into the tree

                    Console.Write("\nOption selected is 1-InOrder:\n");

                    // Print inorder traversal of the BST
                    tree.inorder();     //This prints the elements in the tree

                    //---start
                    //Displaying if TRUE or FALSE for inOrder with PRE DEFINED VALUES
                    //int key1 = 30;      //Checking is the number 30 is inside the tree    //uncomment this line to use pre defined version
                    //---end

                    //---start
                    //Displaying if TRUE or FALSE for inOrder with ASKING USER INPUT
                    Console.Write("\nThe list contains these nodes [50] [30] [20] [40] [70] [80]\nPlease enter a node to check if is available or not in tree: ");  //uncomment this line to use ask user input version
                    userInput = Convert.ToInt32(Console.ReadLine());                                                                                                //uncomment this line to use ask user input version
                    int key1 = userInput;      //Checking is the number from user input is inside the tree                                                          //uncomment this line to use ask user input version
                    //---
                    Console.WriteLine("\nChecking if node " + userInput+ " Contains inside the list... "+(tree.ifNodeExist(key1)+"!"));
                    Console.WriteLine("________________________________________________________________");
                    //---
                    Console.Write("\nPLEASE SELECT OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
                    break;

                case 2:

                    Console.Write("Option selected is 2-PreOrder:\n");

                    // Print inorder traversal of the BST
                    tree.preorder();    //This prints the elements in the tree

                    //Displaying if TRUE or FALSE for PreOrder with PRE DEFINED VALUES
                    //int key2 = 10;      //Checking is the number 10 is inside the tree    //uncomment this line to use pre defined version

                    //Displaying if TRUE or FALSE for PreOrder with ASKING USER INPUT
                    Console.Write("\nThe list contains these nodes [50] [30] [20] [40] [70] [80]\nPlease enter a node to check if is available or not in tree: ");  //uncomment this line to use ask user input version
                    userInput = Convert.ToInt32(Console.ReadLine());                                                                                                //uncomment this line to use ask user input version
                    int key2 = userInput;      //Checking is the number from user input is inside the tree                                                          //uncomment this line to use ask user input version

                    Console.WriteLine("\nChecking if node " + userInput + " Contains inside the list... " + (tree.ifNodeExist(key2) + "!"));
                    Console.WriteLine("________________________________________________________________");
                    Console.Write("\nPLEASE SELECT OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
                    break;

                case 3:

                    Console.Write("Option selected is 3-PostOrder:\n");

                    // Print inorder traversal of the BST
                    tree.postorder();   //This prints the elements in the tree

                    //Displaying if TRUE or FALSE for PostOrder PRE DEFINED VALUES
                    //int key3 = 70;      //Checking is the number 70 is inside the tree    //uncomment this line to use pre defined version

                    //Displaying if TRUE or FALSE for inOrder with ASKING USER INPUT
                    Console.Write("\nThe list contains these nodes [50] [30] [20] [40] [70] [80]\nPlease enter a node to check if is available or not in tree: ");  //uncomment this line to use ask user input version
                    userInput = Convert.ToInt32(Console.ReadLine());                                                                                                //uncomment this line to use ask user input version
                    int key3 = userInput;      //Checking is the number from user input is inside the tree                                                          //uncomment this line to use ask user input version

                    Console.WriteLine("\nChecking if node " + userInput + " Contains inside the list... " + (tree.ifNodeExist(key3) + "!"));
                    Console.WriteLine("________________________________________________________________");
                    Console.Write("\nPLEASE SELECT OPTION: 1-InOrder  2-PreOrder  3-PostOrder  4-Exit\n");
                    break;

                default:
                    Console.WriteLine("\nOption 4 selected to exit the program! bye! ");
                    //Console.ReadKey();  
                    break;
            }
            if (userInput == 4) break;
            userInput = Convert.ToInt32(Console.ReadLine()); //This shows the menu again after program finish, if this is removed the program will loop forever because it's inside the 

            /*int key = 10;
            Console.WriteLine(tree.ifNodeExist(key));*/
            /*if (ifNodeExists(root, key))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");*/
        }
    }   
}